using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Controls;

namespace BCmbBx.Controls
{
    /// <summary>
    /// Interaction logic for MyAgropecuware.Controls.MyComboBox.xaml
    /// </summary>
    public partial class MyComboBox : ComboBox
    {
        public MyComboBox()
        {
            InitializeComponent();
        }

        public string Column(int index)
        {
            try
            {
                DataRowView item = (DataRowView)this.Items.CurrentItem;
                return item.DataView.Table.Rows[this.SelectedIndex][index].ToString();
            }
            catch
            {
                //Sistema.ErrorLogCreator.AddError("ComboBox Error, row -1;");
                return "1"; 
            
            }
        }
    }
}
