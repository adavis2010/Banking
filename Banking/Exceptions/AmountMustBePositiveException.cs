using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Exceptions {


    class AmountMustBePositiveException : Exception {
        //inherit from exception

        public AmountMustBePositiveException() :
            base() { 
        }
        public AmountMustBePositiveException(string Message) :
           base() { 
        }
        public AmountMustBePositiveException(string Message, Exception InnerException) :
            base(Message, InnerException) { 
        }
        //must have all three of these constructors for an exception slide 190


    }
}
