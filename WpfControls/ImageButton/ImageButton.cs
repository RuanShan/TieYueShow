using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfControls.ImageButton {
   public class ImageButton : Button {
      static ImageButton() {
         DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
      }

      #region Dependency Properties
      /// <summary>
      /// Default image for the button
      /// </summary>
      public ImageSource DefaultImage {
         get {
            return (ImageSource)GetValue(DefaultImageProperty);
         }
         set {
            SetValue(DefaultImageProperty, value);
         }
      }

      public static readonly DependencyProperty DefaultImageProperty =
          DependencyProperty.Register("DefaultImage", typeof(ImageSource), typeof(ImageButton),
          new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

      /// <summary>
      /// Image shown if the button is focues or hovered
      /// </summary>
      public ImageSource FocusedImage {
         get {
            return (ImageSource)GetValue(FocusedImageProperty);
         }
         set {
            SetValue(FocusedImageProperty, value);
         }
      }

      public static readonly DependencyProperty FocusedImageProperty =
          DependencyProperty.Register("FocusedImage", typeof(ImageSource), typeof(ImageButton),
          new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

      /// <summary>
      /// Image shown if the button is clicked
      /// </summary>
      public ImageSource PressedImage {
         get {
            return (ImageSource)GetValue(PressedImageProperty);
         }
         set {
            SetValue(PressedImageProperty, value);
         }
      }

      public static readonly DependencyProperty PressedImageProperty =
          DependencyProperty.Register("PressedImage", typeof(ImageSource), typeof(ImageButton),
          new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

      /// <summary>
      /// Image shown if the button is diabled
      /// </summary>
      public ImageSource DisabledImage {
         get {
            return (ImageSource)GetValue(DisabledImageProperty);
         }
         set {
            SetValue(DisabledImageProperty, value);
         }
      }

      public static readonly DependencyProperty DisabledImageProperty =
          DependencyProperty.Register("DisabledImage", typeof(ImageSource), typeof(ImageButton),
          new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

      #endregion
   }
}
