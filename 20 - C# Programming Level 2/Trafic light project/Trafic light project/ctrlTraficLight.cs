using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trafic_light_project.Properties;

namespace Trafic_light_project
{
    public partial class ctrlTraficLight : UserControl
    {
        public ctrlTraficLight()
        {
            InitializeComponent();
        }

        public enum enTraficLight { Red = 0, Orange = 1, Green = 2}
        private enTraficLight CurrentLight = enTraficLight.Red;

        public class TraficLightEventArgs: EventArgs
        {
            public enTraficLight TraficName { get; }
            public int DurationTime { get; }

            public TraficLightEventArgs(enTraficLight traficName, int durationTime)
            {
                TraficName = traficName;
                DurationTime = durationTime;
            }
        }

        public event EventHandler<TraficLightEventArgs> RedLightOn;
        public void RaiseRedLightOn()
        {
            RaiseRedLightOn(new TraficLightEventArgs(enTraficLight.Red, RedTime));
        }
        public void RaiseRedLightOn(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }

        public event EventHandler<TraficLightEventArgs> OrangeLightOn;
        public void RaiseOrangeLightOn()
        {
            RaiseOrangeLightOn(new TraficLightEventArgs(enTraficLight.Orange, RedTime));
        }
        public void RaiseOrangeLightOn(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }


        public event EventHandler<TraficLightEventArgs> GreenLightOn;
        public void RaiseGreenLightOn()
        {
            RaiseGreenLightOn(new TraficLightEventArgs(enTraficLight.Green, RedTime));
        }
        public void RaiseGreenLightOn(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }

        private int _RedTime = 10;
        private int _OrangeTime = 7;
        private int _GreenTime = 5;

        public int RedTime { get { return _RedTime; } set { _RedTime = value; } }
        public int OrangeTime { get { return _OrangeTime; } set { _OrangeTime = value; } }
        public int GreenTime { get { return _GreenTime; } set { _GreenTime = value; } }

        private int GetCurrentTime()
        {
            switch(CurrentLight)
            {
                case enTraficLight.Red:
                    return _RedTime;
                    break;
                case enTraficLight.Orange:
                    return _OrangeTime;
                    break;
                case enTraficLight.Green:
                    return _GreenTime;
                    break;
                default:
                    return _RedTime;
            }
        }

        private void ChangeResoucesOfimgAndlbl()
        {
            switch(CurrentLight)
            {
                case enTraficLight.Red:
                    pbTraficLight.Image = Resources.Red;
                    break;

                case enTraficLight.Orange:
                    pbTraficLight.Image = Resources.Orange;
                    break;

                case enTraficLight.Green:
                    pbTraficLight.Image = Resources.Green;
                    break;

                default:
                    pbTraficLight.Image = Resources.Red;
                    break;
            }
        }

        private int CurrentTimeOfTrafic;
        
        public void Start()
        {
            CurrentTimeOfTrafic = GetCurrentTime();
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblCountTrafic.Text = CurrentTimeOfTrafic.ToString();

            ChangeResoucesOfimgAndlbl();

            if (CurrentTimeOfTrafic == 0)
            {
                Change();
            }
            else
            {
                --CurrentTimeOfTrafic;
            }
        }

        private void Change()
        {
            switch(CurrentLight)
            {
                case enTraficLight.Red:
                    CurrentLight = enTraficLight.Orange;
                    CurrentTimeOfTrafic = GetCurrentTime();
                    lblCountTrafic.Text = CurrentTimeOfTrafic.ToString();
                    ChangeResoucesOfimgAndlbl();

                    RaiseRedLightOn();

                    break;

                case enTraficLight.Orange:
                    CurrentLight = enTraficLight.Green;
                    CurrentTimeOfTrafic = GetCurrentTime();
                    lblCountTrafic.Text = CurrentTimeOfTrafic.ToString();
                    ChangeResoucesOfimgAndlbl();

                    RaiseOrangeLightOn();
                    break;

                case enTraficLight.Green:
                    CurrentLight = enTraficLight.Red;
                    CurrentTimeOfTrafic = GetCurrentTime();
                    lblCountTrafic.Text = CurrentTimeOfTrafic.ToString();
                    ChangeResoucesOfimgAndlbl();

                    RaiseGreenLightOn();
                    break;

                default:
                    CurrentLight = enTraficLight.Red;
                    CurrentTimeOfTrafic = GetCurrentTime();
                    lblCountTrafic.Text = CurrentTimeOfTrafic.ToString();
                    ChangeResoucesOfimgAndlbl();

                    RaiseRedLightOn();
                    break;


            }
        }

    }
}
