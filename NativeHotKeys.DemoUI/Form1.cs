using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NativeHotKeys;
using NativeHotKeys.Controls;

namespace NativeHotKeys.DemoUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCombo<Modifiers>(cboModifier1, true);
            LoadCombo<Modifiers>(cboModifier2, true);
            LoadCombo<Keys>(cboKey);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // Remove key registrations
            foreach(var ctrl in components.Components)
            {
                if(ctrl is HotKey)
                {
                    ((HotKey)ctrl).UnregisterHotKey();
                }
            }

            base.OnClosing(e);
        }

        private void LoadCombo<T>(ComboBox cbo, bool setSelected = false) where T : Enum
        {
            cbo.Items.Clear();
            cbo.Items.AddRange(Enum.GetNames(typeof(T)));
            if (setSelected) cbo.SelectedIndex = 0;
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            string msg = txtMessage.Text;
            var modifier1 = cboModifier1.GetEnumValue<Modifiers>();
            var modifier2 = cboModifier2.GetEnumValue<Modifiers>();
            var key = cboKey.GetEnumValue<Keys>();
            AddHotKey(modifier1,
                      modifier2,
                      key,
                      new Action(() => MessageBox.Show(msg)));

            MessageBox.Show("Created New HotKey", $"{modifier1}+{modifier2}+{key}");
        }

        private void AddHotKey(Modifiers modOne, Modifiers modTwo, Keys key, Action action)
        {
            try
            {
                HotKey hotKey = new HotKey();
                hotKey.RegisterHotkey(modOne | modTwo, key);
                hotKey.HotKeyPressed += (o, e) =>
                {
                    action();
                };
            }
            catch(Exception ex)
            {
                MessageBox.Show("Oops", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
