using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClasses;
using rl = Raylib;
using static Raylib.Raylib;

namespace Tank_Game
{
    class SceneObject
    {
        protected SceneObject parent = null;
        protected List<SceneObject> children = new List<SceneObject>();

        public SceneObject Parent { get => parent; }

        protected Vector2 globalPosition = new Vector2();

        protected Vector2 localPosition = new Vector2();

        protected float globalRotation;

        protected float localRotation;

        public SceneObject()
        {

        }

        public void AddChild(SceneObject child)
        {
            children.Add(child);
            child.parent = this;
        }

        public void RemoveChild(SceneObject child)
        {
            if (children.Remove(child))
            {
                child.parent = null;
            }
        }

        public int GetChildCount()
        {
            return children.Count;
        }

        public SceneObject GetChild(int index)
        {
            return children[index];
        }

        public void UpdateTransform()
        {
            if (parent != null)
            {

            }
            else
            {
                
            }

            foreach (var child in children)
            {
                child.UpdateTransform();
            }
        }

        public void SetPosition(float x, float y)
        {
            
            UpdateTransform();
        }

        public void Translate(float x, float y)
        {
            
            UpdateTransform();
        }

        public void SetRotate(float radians)
        {
            
            UpdateTransform();
        }

        public void Rotate(float radians)
        {
            
            UpdateTransform();
        }

        public void SetScale(float x, float y)
        {
            
            UpdateTransform();
        }

        ~SceneObject()
        {
            if (parent != null)
            {
                parent.RemoveChild(this);
            }

            foreach(var so in children)
            {
                so.parent = null;
            }
        }

        public virtual void OnUpdate()
        {

        }

        public void Update()
        {
            OnUpdate();

            foreach (var child in children)
            {
                child.Update();
            }
        }

        public virtual void OnDraw()
        {

        }

        public void Draw()
        {
            OnDraw();

            foreach (var child in children)
            {
                child.Draw();
            }
        }
    }
}
