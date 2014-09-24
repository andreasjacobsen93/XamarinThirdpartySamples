using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinWeatherCloneApp.Response;

namespace XamarinWeatherCloneApp.Events
{
    /// <summary>
    /// This event class serves arguments in case of a successull request or error, both.
    /// </summary>
    public class RequestEventArgs : EventArgs
    {
        public RequestEventArgs()
        {
            ErrorMessage = string.Empty;
            IsError = false;
            RootObject = new RootObject();
            Exception = new NotImplementedException(Constants.NOT_IMPLEMENTED_EXCEPTION_MESSAGE);
        }

        /// <summary>
        /// Will denote whether the call was successful or not
        /// </summary>
        public bool IsError
        {
            get;
            set;
        }

        /// <summary>
        /// In case of an error, the error message
        /// </summary>
        public string ErrorMessage
        {
            get;
            set;
        }

        /// <summary>
        /// Refers to Inner exception within Weather Client (if any)
        /// </summary>
        public Exception Exception
        {
            get;
            set;
        }

        /// <summary>
        /// Root Object will host the JSON deserialized POCO classes in case of no error
        /// </summary>
        public RootObject RootObject
        {
            get;
            set;
        }

    }
}
