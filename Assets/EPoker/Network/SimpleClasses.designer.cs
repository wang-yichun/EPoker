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
    using uFrame.MVVM.Bindings;
    using uFrame.Serialization;
    
    
    public class NetLoginBase : object {
        
        private String _CustomID;
        
        public String CustomID {
            get {
                return _CustomID;
            }
            set {
                _CustomID = value;
            }
        }
    }
    
    public class NetInitBase : object {
    }
    
    public class NetLogoutBase : object {
    }
    
    public class NetJoinOrCreateRoomBase : object {
        
        private String _RoomId;
        
        public String RoomId {
            get {
                return _RoomId;
            }
            set {
                _RoomId = value;
            }
        }
    }
    
    public class NetLeaveRoomBase : object {
    }
    
    public class NetSetRoomPropertiesBase : object {
        
        private ExitGames.Client.Photon.Hashtable _PropertiesToSet;
        
        public ExitGames.Client.Photon.Hashtable PropertiesToSet {
            get {
                return _PropertiesToSet;
            }
            set {
                _PropertiesToSet = value;
            }
        }
    }
    
    public class NetRaiseEventBase : object {
        
        private Byte _EventCode;
        
        private ExitGames.Client.Photon.Hashtable _EventContent;
        
        public Byte EventCode {
            get {
                return _EventCode;
            }
            set {
                _EventCode = value;
            }
        }
        
        public ExitGames.Client.Photon.Hashtable EventContent {
            get {
                return _EventContent;
            }
            set {
                _EventContent = value;
            }
        }
    }
    
    public class NetSetPlayerPropertiesBase : object {
        
        private Int32 _ActorId;
        
        private ExitGames.Client.Photon.Hashtable _PropertiesToSet;
        
        public Int32 ActorId {
            get {
                return _ActorId;
            }
            set {
                _ActorId = value;
            }
        }
        
        public ExitGames.Client.Photon.Hashtable PropertiesToSet {
            get {
                return _PropertiesToSet;
            }
            set {
                _PropertiesToSet = value;
            }
        }
    }
}
