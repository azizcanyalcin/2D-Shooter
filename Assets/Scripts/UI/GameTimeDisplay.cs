using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// This class inherits from the UIelement class and handles the display of the remaining time
/// </summary>
public class GameTimeDisplay : UIelement
{
    [Tooltip("The TextMeshProUGUI to use for display")]
    public TextMeshProUGUI displayText = null;

    /// <summary>
    /// Description:
    /// Changes the remaining time display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplayGameTime()
    {
        if (displayText != null)
        {
            displayText.text = "Time: " + GameManager.instance.remainingSurvivalTime.ToString();
        }
    }

    /// <summary>
    /// Description:
    /// Overrides the virtual function UpdateUI() of the UIelement class and uses the DisplayHighScore function to update
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public override void UpdateUI()
    {
        // This calls the base update UI function from the UIelement class
        base.UpdateUI();

        // The remaining code is only called for this sub-class of UIelement and not others
        DisplayGameTime();
    }
}
