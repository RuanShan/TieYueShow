using System;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfControls.ImageButton.ViewModels {
   public class ImageButtonViewModel : INotifyPropertyChanged {
      #region Properties
      #region DefaultImageName
      public const string DefaultImageNameProperty = "DefaultImageName";
      private string _defaultImageName = null;
      public string DefaultImageName {
         get {
            return _defaultImageName;
         }
         set {
            if (!Equals(_defaultImageName, value)) {
               _defaultImageName = value;
               OnPropertyChanged(DefaultImageNameProperty);
            }
         }
      }
      #endregion

      #region DisabledImageName
      public const string DisabledImageNameProperty = "DisabledImageName";
      private string _disabledImageName = null;
      public string DisabledImageName {
         get {
            return _disabledImageName;
         }
         set {
            if (!Equals(_disabledImageName, value)) {
               _disabledImageName = value;
               OnPropertyChanged(DisabledImageNameProperty);
            }
         }
      }
      #endregion

      #region FocusedImageName
      public const string FocusedImageNameProperty = "FocusedImageName";
      private string _focusedImageName = null;
      public string FocusedImageName {
         get {
            return _focusedImageName;
         }
         set {
            if (!Equals(_focusedImageName, value)) {
               _focusedImageName = value;
               OnPropertyChanged(FocusedImageNameProperty);
            }
         }
      }
      #endregion

      #region PressedImageName
      public const string PressedImageNameProperty = "PressedImageName";
      private string _pressedImageName = null;
      public string PressedImageName {
         get {
            return _pressedImageName;
         }
         set {
            if (!Equals(_pressedImageName, value)) {
               _pressedImageName = value;
               OnPropertyChanged(PressedImageNameProperty);
            }
         }
      }
      #endregion

      #region Command
      public const String CommandProperty = "Command";
      private ICommand _command = null;
      public ICommand Command {
         get {
            return _command;
         }
         set {
            if (!Equals(_command, value)) {
               _command = value;
               OnPropertyChanged(CommandProperty);
            }
         }
      }
      #endregion

      #region ToolTipText
      public const string ToolTipTextProperty = "ToolTipText";
      private string _toolTipText = null;
      public string ToolTipText {
         get {
            return _toolTipText;
         }
         set {
            if (!Equals(_toolTipText, value)) {
               _toolTipText = value;
               OnPropertyChanged(ToolTipTextProperty);
            }
         }
      }
      #endregion
      #endregion

      #region INotifyPropertyChanged Member

      public event PropertyChangedEventHandler PropertyChanged;

      protected virtual void OnPropertyChanged(string propertyName) {
         if (PropertyChanged != null) {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
         }
      }

      #endregion
   }
}
