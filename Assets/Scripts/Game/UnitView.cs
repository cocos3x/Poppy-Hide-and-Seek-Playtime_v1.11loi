using UnityEngine;

namespace Game
{
    public sealed class UnitView : AnimationUnitView
    {
        // Fields
        public System.Action<Game.Enemy.Node> NodeEntered;
        private Game.RadarView _radar;
        private Game.CircleRadarView _circleRadar;
        private UnityEngine.Animator _enemyBehaviour;
        private UnityEngine.SkinnedMeshRenderer _meshRenderer;
        private UnityEngine.CapsuleCollider _capsuleCollider;
        public UnityEngine.AI.NavMeshAgent MeshAgent;
        private bool _isVictim;
        private bool _isVissible;
        
        // Properties
        public bool IsVictim { get; set; }
        public bool IsVissible { get; set; }
        public bool IsAI { set; }
        public float Radius { get; }
        
        // Methods
        public bool get_IsVictim()
        {
            return (bool)this._isVictim;
        }
        public void set_IsVictim(bool value)
        {
            bool val_8 = value;
            bool val_1 = value;
            this._isVictim = val_1;
            this.gameObject.layer = Utils.LayerUtils.GetVictimLayer(isVictim:  val_1);
            val_8 = val_8 ^ 1;
            this._radar.gameObject.SetActive(value:  val_8);
            this._circleRadar.gameObject.SetActive(value:  val_8);
        }
        public bool get_IsVissible()
        {
            return (bool)this._isVissible;
        }
        public void set_IsVissible(bool value)
        {
            bool val_1 = value;
            this._isVissible = val_1;
            if(this._meshRenderer != null)
            {
                    this._meshRenderer.enabled = val_1;
                return;
            }
            
            throw new NullReferenceException();
        }
        public void set_IsAI(bool value)
        {
            if(this._enemyBehaviour != null)
            {
                    this._enemyBehaviour.enabled = value;
                return;
            }
            
            throw new NullReferenceException();
        }
        public float get_Radius()
        {
            if(this._capsuleCollider != null)
            {
                    return this._capsuleCollider.radius;
            }
            
            throw new NullReferenceException();
        }
        private void Awake()
        {
            if(this._enemyBehaviour != null)
            {
                    this._enemyBehaviour.enabled = false;
                return;
            }
            
            throw new NullReferenceException();
        }
        public override void Die()
        {
            this.PlayAnimation(animationType:  2);
            this._meshRenderer.enabled = true;
            this._enemyBehaviour.enabled = false;
            this.IsVictim = false;
            this._radar.gameObject.SetActive(value:  false);
            this._circleRadar.gameObject.SetActive(value:  false);
        }
        public void FireNodeEnter(Game.Enemy.Node node)
        {
            ActionExtentions.SafeInvoke<Game.Enemy.Node>(invocationTarget:  this.NodeEntered, arg:  node);
        }
        public void RestartNodes()
        {
            this._enemyBehaviour.Rebind();
            this._enemyBehaviour.speed = 0f;
        }
        public UnityEngine.Collider GetSeenVictim()
        {
            UnityEngine.Object val_3;
            if(this._isVictim != false)
            {
                    val_3 = 0;
                return (UnityEngine.Collider)val_3;
            }
            
            val_3 = this._radar.GetSeenVictim();
            if(0 == val_3)
            {
                    return this._circleRadar.GetSeenVictim();
            }
            
            return (UnityEngine.Collider)val_3;
        }
        public void SetOutline(UnityEngine.Material[] materials)
        {
            UnityEngine.Material[] val_1 = new UnityEngine.Material[1];
            val_1[0] = this._meshRenderer.sharedMaterial;
            if(materials != null)
            {
                    Game.Utilities.ArrayUtils.AddRange<UnityEngine.Material>(array: ref  val_1, count:  materials.Length, values:  materials);
            }
            
            this._meshRenderer.materials = val_1;
        }
        public UnitView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
