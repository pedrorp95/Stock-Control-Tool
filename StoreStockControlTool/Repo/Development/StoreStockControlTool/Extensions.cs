using C1.Win.C1List;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using C1.Win.C1Command;
using System.Drawing;

namespace Store_Management.Extensions
{
    public static class Extensions
    {
        internal static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void SetC1ComboVisibleFieldsAll(this Form frm, Control ctl, bool visible = false)
        {
            try
            {
                foreach (Control item in ctl.Controls)
                {
                    if (item.GetType() == typeof(C1Combo))
                    {
                        changeComboVisibleFields((C1Combo)item, visible);
                    }
                    if (item.HasChildren)
                    {
                        SetC1ComboVisibleFieldsAll(frm, item, visible);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private static void changeComboVisibleFields(C1Combo item, bool visible)
        {
            item.ExtendRightColumn = true;
            item.ColumnHeaders = false;
            if (String.IsNullOrEmpty(item.DisplayMember)) return;



            foreach (Split split in item.Splits)
            {
                foreach (C1DisplayColumn columnDisplay in split.DisplayColumns)
                {
                    if (String.IsNullOrWhiteSpace(columnDisplay.DataColumn.DataField)) continue;


                    if (columnDisplay.DataColumn.DataField != item.DisplayMember)
                    {
                        columnDisplay.Visible = visible;
                    }
                }
            }
        }
        public static void FilterClear(this Form frm,Control ctl)
        {
            if (ctl.Controls.Count > 0)
            {
                foreach (Control item in ctl.Controls)
                {
                    if (item.Enabled)
                    {
                        if (typeof(C1TextBox) == item.GetType())
                        {
                            C1TextBox text = (C1TextBox)item;
                            text.Value = "";
                        }
                        else if (typeof(C1Combo) == item.GetType())
                        {
                            C1Combo combo = (C1Combo)item;
                            combo.Text = "";
                            combo.SelectedIndex = -1;
                        }
                        else if (typeof(C1DateEdit) == item.GetType())
                        {
                            C1DateEdit c1DateTimePicker = (C1DateEdit)item;
                            c1DateTimePicker.Value = null;
                        }
                        else if (typeof(C1FlexGrid) == item.GetType())
                        {
                            //clear c1flexgrid
                            C1FlexGrid FlexGrid = (C1FlexGrid)item;
                            while (FlexGrid.Rows.Count > 1)
                            {
                                FlexGrid.Rows.Remove(1);
                            }
                        }
                        else if(typeof(Panel) == item.GetType())
                        {
                            Panel panel = (Panel)item;


                        }
                        else if (typeof(C1DockingTab) == item.GetType())
                        {
                            C1DockingTab c1dock = (C1DockingTab)item;
                        }
                    }
                    if (item.HasChildren)
                    {
                        FilterClear(frm,item);
                    }
                }
            }
            else
            {
                if (ctl.Enabled)
                {
                    if (typeof(C1TextBox) == ctl.GetType() || typeof(C1ComboBox) == ctl.GetType())
                    {
                        ctl.ResetText();
                    }
                    else if (typeof(DateTimePicker) == ctl.GetType())
                    {
                        DateTimePicker c1DateTimePicker = (DateTimePicker)ctl;
                        c1DateTimePicker.ResetText();
                    }
                }
            }
        }
    }
}
