using UnityEngine;

namespace Game.States
{
    public sealed class GameLoadState : GameState
    {
        // Fields
        private Game.Config.GameConfig _config;
        private Injection.Context _context;
        private Game.States.GameStateManager _gameStateManager;
        
        // Methods
        public override void Initialize()
        {
            this._context.Install(objects:  new object[1]);
            throw new NullReferenceException();
        }
        public override void Dispose()
        {
            UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void Game.States.GameLoadState::SceneManagerOnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode arg1)));
        }
        private void SceneManagerOnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode arg1)
        {
            System.Collections.Generic.IEnumerable<TSource> val_4;
            var val_18;
            System.Func<UnityEngine.Vector3, System.Single> val_20;
            var val_21;
            System.Func<UnityEngine.Vector3, System.Single> val_23;
            var val_24;
            System.Func<UnityEngine.Vector3, System.Single> val_26;
            var val_27;
            System.Func<UnityEngine.Vector3, System.Single> val_29;
            bool val_2 = UnityEngine.SceneManagement.SceneManager.SetActiveScene(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = scene.m_Handle & 4294967295});
            UnityEngine.AI.NavMeshTriangulation val_3 = UnityEngine.AI.NavMesh.CalculateTriangulation();
            UnityEngine.Vector4 val_5 = UnityEngine.Vector4.zero;
            val_18 = null;
            val_18 = null;
            val_20 = GameLoadState.<>c.<>9__5_0;
            if(val_20 == null)
            {
                    System.Func<UnityEngine.Vector3, System.Single> val_6 = null;
                val_20 = val_6;
                val_6 = new System.Func<UnityEngine.Vector3, System.Single>(object:  GameLoadState.<>c.__il2cppRuntimeField_static_fields, method:  System.Single GameLoadState.<>c::<SceneManagerOnSceneLoaded>b__5_0(UnityEngine.Vector3 temp));
                GameLoadState.<>c.<>9__5_0 = val_20;
            }
            
            val_21 = null;
            val_21 = null;
            val_23 = GameLoadState.<>c.<>9__5_1;
            if(val_23 == null)
            {
                    System.Func<UnityEngine.Vector3, System.Single> val_8 = null;
                val_23 = val_8;
                val_8 = new System.Func<UnityEngine.Vector3, System.Single>(object:  GameLoadState.<>c.__il2cppRuntimeField_static_fields, method:  System.Single GameLoadState.<>c::<SceneManagerOnSceneLoaded>b__5_1(UnityEngine.Vector3 temp));
                GameLoadState.<>c.<>9__5_1 = val_23;
            }
            
            val_24 = null;
            val_24 = null;
            val_26 = GameLoadState.<>c.<>9__5_2;
            if(val_26 == null)
            {
                    System.Func<UnityEngine.Vector3, System.Single> val_10 = null;
                val_26 = val_10;
                val_10 = new System.Func<UnityEngine.Vector3, System.Single>(object:  GameLoadState.<>c.__il2cppRuntimeField_static_fields, method:  System.Single GameLoadState.<>c::<SceneManagerOnSceneLoaded>b__5_2(UnityEngine.Vector3 temp));
                GameLoadState.<>c.<>9__5_2 = val_26;
            }
            
            val_27 = null;
            val_27 = null;
            val_29 = GameLoadState.<>c.<>9__5_3;
            if(val_29 == null)
            {
                    System.Func<UnityEngine.Vector3, System.Single> val_12 = null;
                val_29 = val_12;
                val_12 = new System.Func<UnityEngine.Vector3, System.Single>(object:  GameLoadState.<>c.__il2cppRuntimeField_static_fields, method:  System.Single GameLoadState.<>c::<SceneManagerOnSceneLoaded>b__5_3(UnityEngine.Vector3 temp));
                GameLoadState.<>c.<>9__5_3 = val_29;
            }
            
            Game.GameModel val_14 = this._context.Get<Game.GameModel>();
            val_14.LevelBounds = System.Linq.Enumerable.Min<UnityEngine.Vector3>(source:  val_4, selector:  val_6);
            mem2[0] = System.Linq.Enumerable.Min<UnityEngine.Vector3>(source:  val_4, selector:  val_8);
            mem2[0] = System.Linq.Enumerable.Max<UnityEngine.Vector3>(source:  val_4, selector:  val_10);
            mem2[0] = System.Linq.Enumerable.Max<UnityEngine.Vector3>(source:  val_4, selector:  val_12);
            object[] val_16 = new object[1];
            val_16[0] = ???.GetComponent<Game.LevelView>();
            this._context.Install(objects:  val_16);
            this._gameStateManager.SwitchToState(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public GameLoadState()
        {
            val_1 = new System.Object();
        }
    
    }

}
