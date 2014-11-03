using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using MVVMLab;
using System.Windows.Data;

namespace MVVMLab 
{ 
   public class ViewBase : UserControl 
   { 
        public ViewBase () 
        {
            
            this.Loaded += new System.Windows.RoutedEventHandler(ViewBase_Loaded);
            this.Unloaded += new System.Windows.RoutedEventHandler(ViewBase_UnLoaded );
        } 
        #region " Declarations " 

        private RoutedEventHandler _errorEventRoutedEventHandler; 

        #endregion 

        #region " Methods " 

        private void ExceptionValidationErrorHandler(object sender, RoutedEventArgs e) 
        { 
            
            System.Windows.Controls.ValidationErrorEventArgs args = (System.Windows.Controls.ValidationErrorEventArgs)e; 
            
            if (args.Error.RuleInError is System.Windows.Controls.ExceptionValidationRule) { 
                
                ViewModelBase _viewModelBase = this.DataContext as ViewModelBase; 
                
                if (_viewModelBase != null) { 
                    
                    //we only want to work with validation errors that are Exceptions because the business object has already recorded the business rule violations using IDataErrorInfo. 
                    BindingExpression bindingExpression = (System.Windows.Data.BindingExpression)args.Error.BindingInError; 
                    string dataItemName = bindingExpression.DataItem.ToString(); 
                    string propertyPath = bindingExpression.ParentBinding.Path.Path; 
                    System.Text.StringBuilder sb = new System.Text.StringBuilder(1024); 
                    
                    foreach (ValidationError validationError in System.Windows.Controls.Validation.GetErrors((DependencyObject)args.OriginalSource)) { 
                        
                        if (validationError.RuleInError is System.Windows.Controls.ExceptionValidationRule) { 
                            sb.AppendFormat("{0} has error ", propertyPath); 
                            
                            if (validationError.Exception == null || validationError.Exception.InnerException == null) { 
                                sb.AppendLine(validationError.ErrorContent.ToString()); 
                            } 
                            
                            else { 
                                sb.AppendLine(validationError.Exception.InnerException.Message); 
                            } 
                        } 
                        
                    } 
                    
                    
                    if (args.Action == ValidationErrorEventAction.Added) { 
                        _viewModelBase.AddUIValidationError(new UIValidationError(dataItemName, propertyPath, sb.ToString())); 
                    } 
                    
                    else if (args.Action == ValidationErrorEventAction.Removed) { 
                        _viewModelBase.RemoveUIValidationError(new UIValidationError(dataItemName, propertyPath, sb.ToString())); 
                    } 
                    
                    else { 
                        //this can only happen if the .NET Framework changes. Better to put a sanity check in now that have a very hard to find bug later. 
                        throw new ArgumentOutOfRangeException("Action", args.Action, "Action value was not programmed."); 
                    } 
                } 
                
            } 
            
            
        } 

        private void ViewBase_Loaded(object sender, System.Windows.RoutedEventArgs e) 
        { 
            //this adds a form level handler and will listen for each control that has the NotifyOnValidationError=True and a ValidationError occurs. 
            _errorEventRoutedEventHandler = new RoutedEventHandler(ExceptionValidationErrorHandler); 
            this.AddHandler(System.Windows.Controls.Validation.ErrorEvent, _errorEventRoutedEventHandler, true); 
        } 

        private void ViewBase_UnLoaded(object sender, System.Windows.RoutedEventArgs e) 
        { 
            this.RemoveHandler(System.Windows.Controls.Validation.ErrorEvent, _errorEventRoutedEventHandler); 
            _errorEventRoutedEventHandler = null; 
        } 

        #endregion 
    } 
} 

