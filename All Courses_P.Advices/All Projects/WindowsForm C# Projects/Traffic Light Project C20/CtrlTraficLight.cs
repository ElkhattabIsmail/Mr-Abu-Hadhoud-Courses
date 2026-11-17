using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Light_Project_C20.Properties;

namespace Traffic_Light_Project_C20
{
    public partial class CtrlTraficLight : UserControl
    {
        public CtrlTraficLight()
        {
            InitializeComponent();
        }

        public enum enTraficLightColors { Green = 0, Red = 1 , Orange = 3 };

        private  enTraficLightColors _TraficLightColor = enTraficLightColors.Green;
        public enTraficLightColors CurrentTraficColor
        {
            get
            {
                return _TraficLightColor;
            }
            set
            {
                _TraficLightColor = value;

                switch (_TraficLightColor)
                {

                    case enTraficLightColors.Green:
                        {
                            lblCountDown.ForeColor = Color.Green;
                            lblCountDown.Text = GreenTime.ToString();
                            pbTraficLight.Image = Resources.Green;
                            break;
                        }
                    case enTraficLightColors.Red:
                        {
                            lblCountDown.ForeColor = Color.Red;
                            lblCountDown.Text = RedTime.ToString();
                            pbTraficLight.Image = Resources.Red;
                            break;
                        }
                    case enTraficLightColors.Orange:
                        {
                            lblCountDown.ForeColor = Color.Orange;
                            lblCountDown.Text = OrangeTime.ToString();
                            pbTraficLight.Image = Resources.Orange;
                            break;
                        }
                }
            }
        }
        public class TraficLightEventArgs : EventArgs
        {
            public enTraficLightColors CurrentTraficColor { get; }
            public int LightDuration { get; }

            public TraficLightEventArgs(enTraficLightColors CurrentTraficColor, int LightDuration)
            {
                this.CurrentTraficColor = CurrentTraficColor;
                this.LightDuration = LightDuration;
            }
        }
        private int _RedTime = 10;
        private int _OrangeTime = 3;
        private int _GreenTime = 10;

        private int _CurrentCountDownValue;

        public int RedTime
        {
            get
            {
                return _RedTime;
            }
            set
            {
                _RedTime = value;
            }
        }
        public int OrangeTime
        {
            get
            {
                return _OrangeTime;
            }
            set
            {
                _OrangeTime = value;
            }
        }

        public int GreenTime
        {
            get
            {
                return _GreenTime;
            }
            set
            {
                _GreenTime = value;
            }
        }

        public int GetCurrentTime()
        {

            switch (_TraficLightColor)
            {
                case enTraficLightColors.Orange:
                    return OrangeTime;

                case enTraficLightColors.Green:
                    return GreenTime;
                case enTraficLightColors.Red:
                    return RedTime;
                default: return RedTime;
            }
        }


        public void Start()
        {
            _CurrentCountDownValue = GetCurrentTime();
            LightTimer.Start();
        }

        public void Stop()
        {
            LightTimer.Stop();
        }
     
        // Events :
        public event EventHandler<TraficLightEventArgs> RedLightOn;
        public void RaiseRedLightOn()
        {
            RaiseRedLightOn(new TraficLightEventArgs(enTraficLightColors.Red, _RedTime));
        }
        protected virtual void RaiseRedLightOn(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }

        public event EventHandler<TraficLightEventArgs> RedLightOff;
        public void RaiseRedLightOff()
        {
            RaiseRedLightOff(new TraficLightEventArgs(enTraficLightColors.Orange, _OrangeTime));
        }
        protected virtual void RaiseRedLightOff(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }

        public event EventHandler<TraficLightEventArgs> OrangeLightOn;
        public void RaiseOrangeLightOn()
        {
            RaiseOrangeLightOn(new TraficLightEventArgs(enTraficLightColors.Orange, _OrangeTime));
        }
        protected virtual void RaiseOrangeLightOn(TraficLightEventArgs e)
        {
            OrangeLightOn?.Invoke(this, e);
        }

        public event EventHandler<TraficLightEventArgs> GreenLightOn;
        public void RaiseGreenLightOn()
        {
            RaiseGreenLightOn(new TraficLightEventArgs(enTraficLightColors.Green, _GreenTime));
        }
        protected virtual void RaiseGreenLightOn(TraficLightEventArgs e)
        {
            GreenLightOn?.Invoke(this, e);
        }

        public event EventHandler<TraficLightEventArgs> GreenLightOff;
        public void RaiseGreenLightOff()
        {
            RaiseGreenLightOff(new TraficLightEventArgs(enTraficLightColors.Orange, _OrangeTime));
        }
        protected virtual void RaiseGreenLightOff(TraficLightEventArgs e)
        {
            RedLightOn?.Invoke(this, e);
        }




        private enTraficLightColors _LightAfterOrangeGreenOrRed;

        private void _ChangeLight()
        {
            switch (_TraficLightColor)
            {
                case enTraficLightColors.Red:
                    _LightAfterOrangeGreenOrRed = enTraficLightColors.Green;
                    CurrentTraficColor = enTraficLightColors.Orange;
                    _CurrentCountDownValue = OrangeTime;
                    lblCountDown.Text = _CurrentCountDownValue.ToString();

                    RaiseOrangeLightOn();

                    break;

                case enTraficLightColors.Orange:
                    if (_LightAfterOrangeGreenOrRed == enTraficLightColors.Green)
                    {
                        CurrentTraficColor = enTraficLightColors.Green;
                        _CurrentCountDownValue = GreenTime;
                        lblCountDown.Text = _CurrentCountDownValue.ToString();

                        RaiseGreenLightOn();
                    }
                    else
                    {
                        CurrentTraficColor = enTraficLightColors.Red;
                        _CurrentCountDownValue = RedTime;
                        lblCountDown.Text = _CurrentCountDownValue.ToString();
                        RaiseRedLightOn();
                    }

                    break;

                case enTraficLightColors.Green:
                    _LightAfterOrangeGreenOrRed = enTraficLightColors.Red;

                    CurrentTraficColor = enTraficLightColors.Orange;
                    _CurrentCountDownValue = OrangeTime;
                    lblCountDown.Text = _CurrentCountDownValue.ToString();
                    RaiseOrangeLightOn();

                    break;

                default:
                    pbTraficLight.Image = Resources.Red;
                    break;
            }


        }

        private void LightTimer_Tick_1(object sender, EventArgs e)
        {
            lblCountDown.Text = _CurrentCountDownValue.ToString();
            if (_CurrentCountDownValue == 0)
            {
                _ChangeLight();
            }
            else
            {
                --_CurrentCountDownValue;
            }
        }
    }
}
