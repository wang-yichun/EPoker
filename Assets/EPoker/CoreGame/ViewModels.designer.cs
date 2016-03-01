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
    using uFrame.IOC;
    using uFrame.Kernel;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.Serialization;
    using UnityEngine;
    using UniRx;
    using yigame.epoker;
    
    
    public partial class CoreGameRootViewModelBase : uFrame.MVVM.ViewModel {
        
        private P<BackGroundViewModel> _BackGroundProperty;
        
        public CoreGameRootViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public virtual P<BackGroundViewModel> BackGroundProperty {
            get {
                return _BackGroundProperty;
            }
            set {
                _BackGroundProperty = value;
            }
        }
        
        public virtual BackGroundViewModel BackGround {
            get {
                return BackGroundProperty.Value;
            }
            set {
                BackGroundProperty.Value = value;
            }
        }
        
        public override void Bind() {
            base.Bind();
            _BackGroundProperty = new P<BackGroundViewModel>(this, "BackGround");
        }
        
        public override void Read(ISerializerStream stream) {
            base.Read(stream);
            		if (stream.DeepSerialize) this.BackGround = stream.DeserializeObject<BackGroundViewModel>("BackGround");;
        }
        
        public override void Write(ISerializerStream stream) {
            base.Write(stream);
            if (stream.DeepSerialize) stream.SerializeObject("BackGround", this.BackGround);;
        }
        
        protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
            base.FillCommands(list);
        }
        
        protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
            base.FillProperties(list);
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_BackGroundProperty, true, false, false, false));
        }
    }
    
    public partial class CoreGameRootViewModel {
        
        public CoreGameRootViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
    }
    
    public partial class BackGroundViewModelBase : uFrame.MVVM.ViewModel {
        
        public BackGroundViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public override void Bind() {
            base.Bind();
        }
        
        public override void Read(ISerializerStream stream) {
            base.Read(stream);
        }
        
        public override void Write(ISerializerStream stream) {
            base.Write(stream);
        }
        
        protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
            base.FillCommands(list);
        }
        
        protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
            base.FillProperties(list);
        }
    }
    
    public partial class BackGroundViewModel {
        
        public BackGroundViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
    }
    
    public partial class CardViewModelBase : uFrame.MVVM.ViewModel {
        
        private P<CardInfo> _InfoProperty;
        
        private P<CardFace> _FaceProperty;
        
        private P<CardPlace> _PlaceProperty;
        
        public CardViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public virtual P<CardInfo> InfoProperty {
            get {
                return _InfoProperty;
            }
            set {
                _InfoProperty = value;
            }
        }
        
        public virtual P<CardFace> FaceProperty {
            get {
                return _FaceProperty;
            }
            set {
                _FaceProperty = value;
            }
        }
        
        public virtual P<CardPlace> PlaceProperty {
            get {
                return _PlaceProperty;
            }
            set {
                _PlaceProperty = value;
            }
        }
        
        public virtual CardInfo Info {
            get {
                return InfoProperty.Value;
            }
            set {
                InfoProperty.Value = value;
            }
        }
        
        public virtual CardFace Face {
            get {
                return FaceProperty.Value;
            }
            set {
                FaceProperty.Value = value;
            }
        }
        
        public virtual CardPlace Place {
            get {
                return PlaceProperty.Value;
            }
            set {
                PlaceProperty.Value = value;
            }
        }
        
        public override void Bind() {
            base.Bind();
            _InfoProperty = new P<CardInfo>(this, "Info");
            _FaceProperty = new P<CardFace>(this, "Face");
            _PlaceProperty = new P<CardPlace>(this, "Place");
        }
        
        public override void Read(ISerializerStream stream) {
            base.Read(stream);
            this.Face = (CardFace)stream.DeserializeInt("Face");;
            this.Place = (CardPlace)stream.DeserializeInt("Place");;
        }
        
        public override void Write(ISerializerStream stream) {
            base.Write(stream);
            stream.SerializeInt("Face", (int)this.Face);;
            stream.SerializeInt("Place", (int)this.Place);;
        }
        
        protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModelCommandInfo> list) {
            base.FillCommands(list);
        }
        
        protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModelPropertyInfo> list) {
            base.FillProperties(list);
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_InfoProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_FaceProperty, false, false, true, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_PlaceProperty, false, false, true, false));
        }
    }
    
    public partial class CardViewModel {
        
        public CardViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
    }
}
