using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kanc.Core.Infrastructure.Utils
{
    public class Colector
    {
        /// <summary>
        /// Loot recursive and collect the controls
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contol"></param>
        /// <param name="list"></param>
        private static void LoopControls<T>(Control parentContol, List<T> list) where T : Control
        {
            foreach (Control ctrl in parentContol.Controls)
            {
                if (ctrl is T)
                {
                    list.Add(ctrl as T);
                }
                else
                {
                    if (ctrl.Controls.Count > 0)
                    {
                        LoopControls(ctrl, list);
                    }
                }
            }
        }


        /// <summary>
        /// Collect all the controls from type 'T'
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="contol"></param>
        /// <returns></returns>
        public static List<T> CollectControls<T>(Control parent) where T : Control
        {
            List<T> list = new List<T>();
            LoopControls(parent, list);
            return list;
        }

    }
}
