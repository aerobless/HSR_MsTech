using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace MVVMLab
{
    public class ViewModelBase : INotifyPropertyChanged 
    { 
    
    #region " Declarations " 
    
    private Dictionary<string, UIValidationError> _uIValidationErrorDictionary = new Dictionary<string, UIValidationError>(); 
    
    #endregion 
    
    #region " Events " 
    
 
   
    #endregion 
    
    #region " Properties " 
    
    public int UIValidationErrorCount { 
        get { return _uIValidationErrorDictionary.Count; } 
    } 
    
    public string UIValidationErrorMessages { 
        get { 
            
            if (UIValidationErrorCount > 0) { 
                
                System.Text.StringBuilder sb = new System.Text.StringBuilder(1024); 
                
                foreach (KeyValuePair<string, UIValidationError> kvp in _uIValidationErrorDictionary) { 
                    sb.AppendLine(kvp.Value.ToFriendlyErrorMessage()); 
                } 
                
                return sb.ToString(); 
            } 
            
            else { 
                return string.Empty; 
            } 
        } 
        
    } 
    
    #endregion 
    
    #region " Constructor " 
    
    public ViewModelBase() 
    { 
    } 
    
    #endregion 
    
    #region " PropertyChanged Methods " 
    
    protected void OnPropertyChanged(string name) 
    {
        PropertyChangedEventHandler ph = this.PropertyChanged; 

        if (ph != null) 
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name)); 
        }         
    } 
    
    #endregion 
    
    #region " UIValidationError Methods " 
    
    public void AddUIValidationError(UIValidationError e) 
    { 
        _uIValidationErrorDictionary.Add(e.Key, e); 
        OnPropertyChanged("UIValidationErrorMessages"); 
        OnPropertyChanged("UIValidationErrorCount"); 
    } 
    
    public void RemoveUIValidationError(UIValidationError e) 
    { 
        _uIValidationErrorDictionary.Remove(e.Key); 
        OnPropertyChanged("UIValidationErrorMessages"); 
        OnPropertyChanged("UIValidationErrorCount"); 
    } 
    
    protected void ClearUIValidationErrors() 
    { 
        _uIValidationErrorDictionary.Clear(); 
        OnPropertyChanged("UIValidationErrorMessages"); 
        OnPropertyChanged("UIValidationErrorCount"); 
    } 
        
#endregion 

    #region INotifyPropertyChanged Members

    public event PropertyChangedEventHandler PropertyChanged;

    #endregion
    } 

}
