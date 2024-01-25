using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent
{
    public class SmartDoor : SimpleDoor
    {
        private bool alarmEnabled;
        private bool pagerNotificationEnabled;
        private bool autoCloseEnabled;

        private Alert alert;
        private Notify notify;
        private AutoClose autoClose;

        public event DoorEventHandler TimerAlert;

        public SmartDoor(bool alarmEnabled, bool pagerNotificationEnabled, bool autoCloseEnabled)
        {
            this.alarmEnabled = alarmEnabled;
            this.pagerNotificationEnabled = pagerNotificationEnabled;
            this.autoCloseEnabled = autoCloseEnabled;

            alert = new Alert();
            notify = new Notify();
            autoClose = new AutoClose();
        }

        public override void Open()
        {
            base.Open();

            if (autoCloseEnabled)
            {
     
                autoClose.SetTimer(10, OnAutoCloseElapsed);
            }
        }

        private void OnAutoCloseElapsed()
        {
            Close();

            // Notify subscribers about auto-close event
            OnTimerAlert();
        }

        protected virtual void OnTimerAlert()
        {
            TimerAlert?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnDoorOpened()
        {
            base.OnDoorOpened();

            if (alarmEnabled)
            {
                alert.Activate();
            }

            if (pagerNotificationEnabled)
            {
                notify.SendNotification();
            }
        }
    }

}
