﻿using ControllerProject.Service;
using Model;
using Model.Entity;
using MoodDetectorWebApp.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MoodDetectorWebApp.Controllers
{
    public class ManageUsersController : Controller
    {
        IUserService _userService;
        IRegisterAuthenticator _registerAuthenticator;

        public ManageUsersController(IUserService userService, IRegisterAuthenticator registerAuthenticator)
        {
            _userService = userService;
            _registerAuthenticator = registerAuthenticator;
        }

        [HttpGet]
        public ActionResult ViewUsers()
        {
            List<User> users = _userService.GetUsers();
            return View("ViewUsers", users);
        }

        [HttpGet]
        public ActionResult AddUser()
        {
            return View("AddUser");
        }

        [HttpPost]
        public ActionResult AddUser(AddUserModel addUserModel)
        {
            AddUser addUser = new AddUser(
                addUserModel.Username,
                addUserModel.Password,
                addUserModel.Email,
                addUserModel.Firstname,
                addUserModel.Lastname,
                addUserModel.AccessRights
                );
            /*if (!_registerAuthenticator.IsRegisterDataCorrect(addUser))
            {
                return View("DeleteUser");
            }*/
            _userService.AddNewUser(addUser);
            return View("SuccessfulAdd");
        }

        [HttpGet]
        public ActionResult EditUser(int id)
        {
            var user = _userService.GetAddUser(id);
            return View("EditUser", user);
        }

        [HttpPost]
        public ActionResult EditUser(AddUserModel addUserModel, int id)
        {
            AddUser addUser = new AddUser(
                addUserModel.Username,
                addUserModel.Password,
                addUserModel.Email,
                addUserModel.Firstname,
                addUserModel.Lastname,
                addUserModel.AccessRights
                );
            /*if (!_registerAuthenticator.IsRegisterDataCorrect(addUser))
            {
                return View("DeleteUser");
            }*/
            _userService.EditUser(addUser, id);
            return View("SuccessfulAdd");
        }

        [HttpGet]
        public ActionResult DeleteUser(int id)
        {
            return View("DeleteUser", _userService.GetUser(_userService.FindUsernameById(id)));
        }

        public ActionResult DeleteUserPost(AddUserModel addUserModel, int id)
        {
            _userService.DeleteUser(id);
            return View("SuccessfulAdd");
        }
    }
}