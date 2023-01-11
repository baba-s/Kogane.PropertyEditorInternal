using System;
using System.Reflection;
using UnityEditor;

namespace Kogane
{
    public static class PropertyEditorInternal
    {
        private const BindingFlags BINDING_ATTRS = BindingFlags.Instance | BindingFlags.NonPublic;

        private static readonly Type TYPE = typeof( Editor ).Assembly.GetType( "UnityEditor.PropertyEditor" );

        public static void ExpandAllComponents( EditorWindow propertyEditor )
        {
            var method = TYPE.GetMethod( nameof( ExpandAllComponents ), BINDING_ATTRS );
            method.Invoke( propertyEditor, Array.Empty<object>() );
            propertyEditor.Repaint();
        }

        public static bool IsAnyComponentCollapsed( EditorWindow propertyEditor )
        {
            var method = TYPE.GetMethod( nameof( IsAnyComponentCollapsed ), BINDING_ATTRS );
            return ( bool )method.Invoke( propertyEditor, Array.Empty<object>() );
        }

        public static void CollapseAllComponents( EditorWindow propertyEditor )
        {
            var method = TYPE.GetMethod( nameof( CollapseAllComponents ), BINDING_ATTRS );
            method.Invoke( propertyEditor, Array.Empty<object>() );
            propertyEditor.Repaint();
        }

        public static bool IsAnyComponentExpanded( EditorWindow propertyEditor )
        {
            var method = TYPE.GetMethod( nameof( IsAnyComponentExpanded ), BINDING_ATTRS );
            return ( bool )method.Invoke( propertyEditor, Array.Empty<object>() );
        }
    }
}