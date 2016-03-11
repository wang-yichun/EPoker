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
    using uFrame.Serialization;
    using yigame.epoker;
    using UniRx;
    using uFrame.IOC;
    using uFrame.Kernel;
    using uFrame.MVVM;
    
    
    public class OutOfGameRootControllerBase : uFrame.MVVM.Controller {
        
        private uFrame.MVVM.IViewModelManager _OutOfGameRootViewModelManager;
        
        private OutOfGameRootViewModel _OutOfGameRoot;
        
        [uFrame.IOC.InjectAttribute("OutOfGameRoot")]
        public uFrame.MVVM.IViewModelManager OutOfGameRootViewModelManager {
            get {
                return _OutOfGameRootViewModelManager;
            }
            set {
                _OutOfGameRootViewModelManager = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("OutOfGameRoot")]
        public OutOfGameRootViewModel OutOfGameRoot {
            get {
                return _OutOfGameRoot;
            }
            set {
                _OutOfGameRoot = value;
            }
        }
        
        public IEnumerable<OutOfGameRootViewModel> OutOfGameRootViewModels {
            get {
                return OutOfGameRootViewModelManager.OfType<OutOfGameRootViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeOutOfGameRoot(((OutOfGameRootViewModel)(viewModel)));
        }
        
        public virtual OutOfGameRootViewModel CreateOutOfGameRoot() {
            return ((OutOfGameRootViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModel CreateEmpty() {
            return new OutOfGameRootViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeOutOfGameRoot(OutOfGameRootViewModel viewModel) {
            // This is called when a OutOfGameRootViewModel is created
            viewModel.DoLogin.Action = this.DoLoginHandler;
            viewModel.DoEnterRoom.Action = this.DoEnterRoomHandler;
            viewModel.DoQuitRoom.Action = this.DoQuitRoomHandler;
            OutOfGameRootViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            OutOfGameRootViewModelManager.Remove(viewModel);
        }
        
        public virtual void DoLogin(OutOfGameRootViewModel viewModel) {
        }
        
        public virtual void DoEnterRoom(OutOfGameRootViewModel viewModel) {
        }
        
        public virtual void DoQuitRoom(OutOfGameRootViewModel viewModel) {
        }
        
        public virtual void DoLoginHandler(DoLoginCommand command) {
            this.DoLogin(command.Sender as OutOfGameRootViewModel);
        }
        
        public virtual void DoEnterRoomHandler(DoEnterRoomCommand command) {
            this.DoEnterRoom(command.Sender as OutOfGameRootViewModel);
        }
        
        public virtual void DoQuitRoomHandler(DoQuitRoomCommand command) {
            this.DoQuitRoom(command.Sender as OutOfGameRootViewModel);
        }
    }
    
    public class CanvasRootControllerBase : uFrame.MVVM.Controller {
        
        private uFrame.MVVM.IViewModelManager _CanvasRootViewModelManager;
        
        private OutOfGameRootViewModel _OutOfGameRoot;
        
        [uFrame.IOC.InjectAttribute("CanvasRoot")]
        public uFrame.MVVM.IViewModelManager CanvasRootViewModelManager {
            get {
                return _CanvasRootViewModelManager;
            }
            set {
                _CanvasRootViewModelManager = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("OutOfGameRoot")]
        public OutOfGameRootViewModel OutOfGameRoot {
            get {
                return _OutOfGameRoot;
            }
            set {
                _OutOfGameRoot = value;
            }
        }
        
        public IEnumerable<CanvasRootViewModel> CanvasRootViewModels {
            get {
                return CanvasRootViewModelManager.OfType<CanvasRootViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeCanvasRoot(((CanvasRootViewModel)(viewModel)));
        }
        
        public virtual CanvasRootViewModel CreateCanvasRoot() {
            return ((CanvasRootViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModel CreateEmpty() {
            return new CanvasRootViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeCanvasRoot(CanvasRootViewModel viewModel) {
            // This is called when a CanvasRootViewModel is created
            viewModel.OpenClosePanel.Action = this.OpenClosePanelHandler;
            CanvasRootViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            CanvasRootViewModelManager.Remove(viewModel);
        }
        
        public virtual void OpenClosePanelHandler(OpenClosePanelCommand command) {
            this.OpenClosePanel(command.Sender as CanvasRootViewModel, command);
        }
        
        public virtual void OpenClosePanel(CanvasRootViewModel viewModel, OpenClosePanelCommand arg) {
        }
    }
    
    public class PanelControllerBase : uFrame.MVVM.Controller {
        
        private uFrame.MVVM.IViewModelManager _PanelViewModelManager;
        
        private OutOfGameRootViewModel _OutOfGameRoot;
        
        [uFrame.IOC.InjectAttribute("Panel")]
        public uFrame.MVVM.IViewModelManager PanelViewModelManager {
            get {
                return _PanelViewModelManager;
            }
            set {
                _PanelViewModelManager = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute("OutOfGameRoot")]
        public OutOfGameRootViewModel OutOfGameRoot {
            get {
                return _OutOfGameRoot;
            }
            set {
                _OutOfGameRoot = value;
            }
        }
        
        public IEnumerable<PanelViewModel> PanelViewModels {
            get {
                return PanelViewModelManager.OfType<PanelViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializePanel(((PanelViewModel)(viewModel)));
        }
        
        public virtual PanelViewModel CreatePanel() {
            return ((PanelViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModel CreateEmpty() {
            return new PanelViewModel(this.EventAggregator);
        }
        
        public virtual void InitializePanel(PanelViewModel viewModel) {
            // This is called when a PanelViewModel is created
            viewModel.PanelIn.Action = this.PanelInHandler;
            viewModel.PanelOut.Action = this.PanelOutHandler;
            PanelViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            PanelViewModelManager.Remove(viewModel);
        }
        
        public virtual void PanelIn(PanelViewModel viewModel) {
        }
        
        public virtual void PanelOut(PanelViewModel viewModel) {
        }
        
        public virtual void PanelInHandler(PanelInCommand command) {
            this.PanelIn(command.Sender as PanelViewModel);
        }
        
        public virtual void PanelOutHandler(PanelOutCommand command) {
            this.PanelOut(command.Sender as PanelViewModel);
        }
    }
    
    public class LoginPanelControllerBase : PanelController {
        
        private uFrame.MVVM.IViewModelManager _LoginPanelViewModelManager;
        
        [uFrame.IOC.InjectAttribute("LoginPanel")]
        public uFrame.MVVM.IViewModelManager LoginPanelViewModelManager {
            get {
                return _LoginPanelViewModelManager;
            }
            set {
                _LoginPanelViewModelManager = value;
            }
        }
        
        public IEnumerable<LoginPanelViewModel> LoginPanelViewModels {
            get {
                return LoginPanelViewModelManager.OfType<LoginPanelViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeLoginPanel(((LoginPanelViewModel)(viewModel)));
        }
        
        public virtual LoginPanelViewModel CreateLoginPanel() {
            return ((LoginPanelViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModel CreateEmpty() {
            return new LoginPanelViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeLoginPanel(LoginPanelViewModel viewModel) {
            // This is called when a LoginPanelViewModel is created
            LoginPanelViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            LoginPanelViewModelManager.Remove(viewModel);
        }
    }
    
    public class LobbyPanelControllerBase : PanelController {
        
        private uFrame.MVVM.IViewModelManager _LobbyPanelViewModelManager;
        
        [uFrame.IOC.InjectAttribute("LobbyPanel")]
        public uFrame.MVVM.IViewModelManager LobbyPanelViewModelManager {
            get {
                return _LobbyPanelViewModelManager;
            }
            set {
                _LobbyPanelViewModelManager = value;
            }
        }
        
        public IEnumerable<LobbyPanelViewModel> LobbyPanelViewModels {
            get {
                return LobbyPanelViewModelManager.OfType<LobbyPanelViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeLobbyPanel(((LobbyPanelViewModel)(viewModel)));
        }
        
        public virtual LobbyPanelViewModel CreateLobbyPanel() {
            return ((LobbyPanelViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModel CreateEmpty() {
            return new LobbyPanelViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeLobbyPanel(LobbyPanelViewModel viewModel) {
            // This is called when a LobbyPanelViewModel is created
            LobbyPanelViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            LobbyPanelViewModelManager.Remove(viewModel);
        }
    }
    
    public class RoomPanelControllerBase : PanelController {
        
        private uFrame.MVVM.IViewModelManager _RoomPanelViewModelManager;
        
        [uFrame.IOC.InjectAttribute("RoomPanel")]
        public uFrame.MVVM.IViewModelManager RoomPanelViewModelManager {
            get {
                return _RoomPanelViewModelManager;
            }
            set {
                _RoomPanelViewModelManager = value;
            }
        }
        
        public IEnumerable<RoomPanelViewModel> RoomPanelViewModels {
            get {
                return RoomPanelViewModelManager.OfType<RoomPanelViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeRoomPanel(((RoomPanelViewModel)(viewModel)));
        }
        
        public virtual RoomPanelViewModel CreateRoomPanel() {
            return ((RoomPanelViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModel CreateEmpty() {
            return new RoomPanelViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeRoomPanel(RoomPanelViewModel viewModel) {
            // This is called when a RoomPanelViewModel is created
            RoomPanelViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            RoomPanelViewModelManager.Remove(viewModel);
        }
    }
}
