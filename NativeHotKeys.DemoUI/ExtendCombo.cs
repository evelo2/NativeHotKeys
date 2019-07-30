using System;
using System.Windows.Forms;

namespace NativeHotKeys.DemoUI
{
    public static class ExtendCombo
    {
        public static T GetEnumValue<T>(this ComboBox cbo) where T : Enum
        {
            T returnValue = default(T);
            if (cbo.SelectedIndex == -1) return returnValue;

            try
            {
                returnValue = (T)Enum.Parse(typeof(T), cbo.SelectedItem.ToString());
            }
            catch
            {
                // Do nothing.
            }

            return returnValue;
        }
    }
}
