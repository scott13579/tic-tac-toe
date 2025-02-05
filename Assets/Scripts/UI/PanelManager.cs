using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    [SerializeField] private PanelController startPanelController;
    
    public enum PanelType { StartPanel, WinPanel, DrawPanel, LosePanel }

    private PanelController _currentPanelController;
    
    /// <summary>
    /// 표시할 패널 정보 전달하는 함수
    /// </summary>
    /// <param name="panelType"> 표시할 패널 </param>
    public void ShowPanel(PanelType panelType)
    {
        switch (panelType)
        {
            case PanelType.StartPanel:
                
                break;
            case PanelType.WinPanel:
                
                break;
            case PanelType.DrawPanel:
                
                break;
            case PanelType.LosePanel:
                
                break;
        }
    }
}