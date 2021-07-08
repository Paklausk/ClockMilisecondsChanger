using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeChanger.Objects
{
    public delegate void TimeDiffChangedHandle(long newValue);
    public class TimeDifference
    {
        public long ValueMs
        {
            get; protected set;
        }
        public event TimeDiffChangedHandle OnChanged;
        public TimeDifference(long timeDiffMs)
        {
            ValueMs = timeDiffMs;
        }
        public void Add(long ms)
        {
            ValueMs += ms;
            OnValueChanged();
        }
        public void Substract(long ms)
        {
            ValueMs -= ms;
            OnValueChanged();
        }
        protected void OnValueChanged()
        {
            OnChanged?.Invoke(ValueMs);
        }
    }
}
