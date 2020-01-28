using System;

namespace Business_Scheduler.Exceptions
{
    public class OutsideBusinessHoursException : Exception
    {
        public OutsideBusinessHoursException()
            : base("Can not schedule an appointment outside of business hours.")
        {
        }

        public OutsideBusinessHoursException(string message)
            : base(message)
        {
        }

        public OutsideBusinessHoursException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class OverlapAppointmentException : Exception
    {
        public OverlapAppointmentException()
            : base("Can not have two appointments overlap one another")
        {
        }

        public OverlapAppointmentException(string message)
            : base(message)
        {
        }

        public OverlapAppointmentException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class IncorrectLoginException : Exception
    {
        public IncorrectLoginException()
            : base("Incorrect login credentials were entered")
        {
        }

        public IncorrectLoginException(string message)
            : base(message)
        {
        }

        public IncorrectLoginException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class InvalidCustomerDataException : Exception
    {
        public InvalidCustomerDataException()
            : base("Nonexistent or invalid customer data was entered")
        {
        }

        public InvalidCustomerDataException(string message)
            : base(message)
        {
        }

        public InvalidCustomerDataException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
