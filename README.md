# Kogane Property Editor Internal

PropertyEditor クラスの internal な機能にアクセスできる機能

## 使用例

```csharp
using System;
using System.Linq;
using Kogane.Internal;
using UnityEditor;
using UnityEngine;

public static class Example
{
    private static readonly Type TYPE = typeof( Editor ).Assembly.GetType( "UnityEditor.PropertyEditor" );

    [MenuItem( "Tools/Expand All Components", true )]
    private static bool IsAnyComponentCollapsed()
    {
        return PropertyEditorInternal.IsAnyComponentCollapsed( GetPropertyEditor() );
    }

    [MenuItem( "Tools/Expand All Components" )]
    private static void ExpandAllComponents()
    {
        PropertyEditorInternal.ExpandAllComponents( GetPropertyEditor() );
    }

    [MenuItem( "Tools/Collapse All Components", true )]
    private static bool IsAnyComponentExpanded()
    {
        return PropertyEditorInternal.IsAnyComponentExpanded( GetPropertyEditor() );
    }

    [MenuItem( "Tools/Collapse All Components" )]
    private static void CollapseAllComponents()
    {
        PropertyEditorInternal.CollapseAllComponents( GetPropertyEditor() );
    }

    private static EditorWindow GetPropertyEditor()
    {
        return Resources
                .FindObjectsOfTypeAll( TYPE )
                .FirstOrDefault() as EditorWindow
            ;
    }
}
```