using System;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public interface INotificationObserver
    {
        void Update(string message);
    }

    public class UINotification : INotificationObserver
    {
        private readonly Action<string> _showMessage;

        public UINotification(Action<string> showMessage)
        {
            _showMessage = showMessage;
        }

        public void Update(string message)
        {
            _showMessage(message);
        }
    }

    public interface INotificationSubject
    {
        void Attach(INotificationObserver observer);
        void Detach(INotificationObserver observer);
        void Notify(string message);
    }
    public sealed class AppointmentNotificationSystem
    {
        private static readonly AppointmentNotificationSystem _instance = new AppointmentNotificationSystem();
        private readonly List<INotificationObserver> _observers = new List<INotificationObserver>();

        private AppointmentNotificationSystem() { }

        public static AppointmentNotificationSystem Instance => _instance;

        public void Attach(INotificationObserver observer) => _observers.Add(observer);
        public void Notify(string message)
        {
            foreach (var obs in _observers)
                obs.Update(message);
        }
    }

    //public class AppointmentNotificationSystem : INotificationSubject
    //{
    //    private List<INotificationObserver> _observers = new List<INotificationObserver>();

    //    public void Attach(INotificationObserver observer)
    //    {
    //        _observers.Add(observer);
    //    }

    //    public void Detach(INotificationObserver observer)
    //    {
    //        _observers.Remove(observer);
    //    }

    //    public void Notify(string message)
    //    {
    //        foreach (var observer in _observers)
    //        {
    //            observer.Update(message);
    //        }
    //    }

    //    public void BookAppointment(AppointmentBooking appointment)
    //    {
    //        appointment.Register();
    //        Notify($"New appointment booked: {appointment.appointmentPurpose} on {appointment.appointmentDate}");
    //    }
    //}

    // Example observer implementation
    public class EmailNotification : INotificationObserver
    {
        public void Update(string message)
        {
            // Simulate email sending
            Console.WriteLine($"Email sent: {message}");
        }
    }

    public class SMSNotification : INotificationObserver
    {
        public void Update(string message)
        {
            // Simulate SMS sending
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}