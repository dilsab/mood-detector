﻿//Construct a PhotoDetector
var detector = new affdex.PhotoDetector();
var imageCount = 1;
var detectionId;
//Enable detection of all Expressions, Emotions and Emojis classifiers.
detector.detectAllEmotions();
detector.detectAllExpressions();
detector.detectAllEmojis();
detector.detectAllAppearance();

//Add a callback to notify when the detector is initialized and ready for runing.
detector.addEventListener("onInitializeSuccess", function () {
    log('#logs', "The detector reports initialized");

    $("#upload_button").css("visibility", "visible");
});

//Add a callback to receive the results from processing an image.
//The faces object contains the list of the faces detected in an image.
//Faces object contains probabilities for all the different expressions, emotions and appearance metrics
detector.addEventListener("onImageResultsSuccess", function (faces, image) {
    drawImage(image);
    $('#results').html("");
    if (faces.length > 0) {
        $.ajax({
            type: "POST",
            url: "/Detector/PostMoods",
            data: { detectionId: this.detectionId, moods: JSON.stringify(faces[0].emotions) },
            dataType: "json"
        });
        log('#results', "Image number " + imageCount + " uploaded successfully");
        imageCount += 1;
    }
});

//Add a callback to notify if failed receive the results from processing an image.
detector.addEventListener("onImageResultsFailure", function (image, timestamp, error) {
    log('#logs', 'Failed to process image err=' + error);
});

//Initialize the emotion detector
log("#logs", "Starting the detector .. please wait");
detector.start();


//Once the image is loaded, pass it down for processing
function imageLoaded(event) {

    var contxt = document.createElement('canvas').getContext('2d');
    contxt.canvas.width = this.width;
    contxt.canvas.height = this.height;
    contxt.drawImage(this, 0, 0, this.width, this.height);

    // Pass the image to the detector to track emotions
    if (detector && detector.isRunning) {
        detector.process(contxt.getImageData(0, 0, this.width, this.height), 0);
    }
}

//Load the selected image
function loadFile(event, detectionId) {
    this.detectionId = detectionId;
    $('#results').html("");
    var img = new Image();
    var reader = new FileReader();
    reader.onload = function () {
        img.onload = imageLoaded;
        img.src = reader.result;
    };
    reader.readAsDataURL(event.target.files[0]);
};

//Convienence function for logging to the DOM
function log(node_name, msg) {
    $(node_name).append("<span>" + msg + "</span><br />")
}

//Draw Image to container
function drawImage(img) {
    var contxt = $('#image_canvas')[0].getContext('2d');

    var temp = document.createElement('canvas').getContext('2d');
    temp.canvas.width = img.width;
    temp.canvas.height = img.height;
    temp.putImageData(img, 0, 0);

    var image = new Image();
    image.src = temp.canvas.toDataURL("image/png");

    //Scale the image to 640x480 - the size of the display container.
    contxt.canvas.width = img.width <= 640 ? img.width : 640;
    contxt.canvas.height = img.height <= 480 ? img.height : 480;

    var hRatio = contxt.canvas.width / img.width;
    var vRatio = contxt.canvas.height / img.height;
    var ratio = Math.min(hRatio, vRatio);

    //Draw the image on the display canvas
    contxt.clearRect(0, 0, contxt.canvas.width, contxt.canvas.height);

    contxt.scale(ratio, ratio);
    contxt.drawImage(image, 0, 0);
}

//Draw the detected facial feature points on the image
function drawFeaturePoints(img, featurePoints) {
    var contxt = $('#image_canvas')[0].getContext('2d');

    var hRatio = contxt.canvas.width / img.width;
    var vRatio = contxt.canvas.height / img.height;
    var ratio = Math.min(hRatio, vRatio);

    contxt.strokeStyle = "#FFFFFF";
    for (var id in featurePoints) {
        contxt.beginPath();
        contxt.arc(featurePoints[id].x,
            featurePoints[id].y, 2, 0, 2 * Math.PI);
        contxt.stroke();

    }
}
