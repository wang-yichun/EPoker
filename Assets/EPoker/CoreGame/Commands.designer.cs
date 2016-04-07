// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace yigame.epoker {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Kernel;
    using uFrame.MVVM;
    using uFrame.Serialization;
    using yigame.epoker;
    using UnityEngine;
    
    
    public partial class RefreshCoreGameCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class RootMatchBeganCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class QuitCoreGameCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class PlayerJoinCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class PlayerLeaveCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class CalcPosIdAndReposCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class TurnNextCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class RootMatchOverCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class SelectCardCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class DeselectCardCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class PlayerReadyCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class PlayerCancelCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class MatchBeganCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class BeganToPlayCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class BeganToWaitCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class TurnOnCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class TurnOffCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class WinCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class OverCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class InitOKCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class RefreshPlayerCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class ButtonReadyClickedCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class ButtonStartClickedCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class LogInfoCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class ReorderCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class ButtonPassClickedCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class ButtonDealClickedCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class ButtonTurnNextCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class ShowCardsToPileCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class PileCardsReorderCommand : uFrame.MVVM.ViewModelCommand {
    }
    
    public partial class AddCardsCommand : ViewModelCommand {
        
        private List<CardInfo> _CardInfos;
        
        public List<CardInfo> CardInfos {
            get {
                return _CardInfos;
            }
            set {
                _CardInfos = value;
            }
        }
    }
    
    public partial class RemoveCardsCommand : ViewModelCommand {
        
        private List<CardInfo> _CardInfos;
        
        public List<CardInfo> CardInfos {
            get {
                return _CardInfos;
            }
            set {
                _CardInfos = value;
            }
        }
    }
}
