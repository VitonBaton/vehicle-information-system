﻿namespace AccountsService.Constants.Logger
{
    public class LoggingForms
    {
        public const string RegistrationAttempt = "The user [{username}]:[{email}] is trying to register";
        public const string Registred = "The user [{username}]:[{email}] was successfully registred";
        public const string FailedToRegister = "The user [{username}]:[{email}] has failed the registration: [{error}]";
    
        public const string LoginAttempt = "The user [{}] is trying to log in";
        public const string LoggedIn = "The user [{email}] was successfully logged in";

        public const string AddedToRole = "The user [{username}]:[{email}] was successfully added to role {role}";


        public const string UserNotFound = "The user [{email}] was not found";  
        public const string InvalidCredentials = "The user [{email}] has failed authentication";

        public const string ExceptionForm = "[{exception}] has occured with status code [{statusCode}]: [{message}]";
    }
}
