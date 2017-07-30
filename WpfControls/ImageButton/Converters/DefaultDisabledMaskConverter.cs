using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfControls.ImageButton.Converters {
   public class DefaultDisabledMaskConverter : IMultiValueConverter {
      #region IMultiValueConverter Member

      public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
         if (values == null || values.Length == 0) {
            return DependencyProperty.UnsetValue;
         } else if (values[0] is ImageSource) {
            return null;
         } else if (values.Length == 2 && values[1] is ImageSource) {
            return new ImageBrush(values[1] as ImageSource) {
               Opacity = 0.5
            };
         } else {
            return DependencyProperty.UnsetValue;
         }
      }

      public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) {
         throw new NotImplementedException();
      }

      #endregion
   }
}
