using System;

namespace ThuyTienNguyen_C969_ScheduleManagement.DBModel
{
    class LoginValidator : ApplicationException
    {
       
        public LoginValidator(string exceptionMessage) : base(exceptionMessage)
        {

        }
       
    }
}
