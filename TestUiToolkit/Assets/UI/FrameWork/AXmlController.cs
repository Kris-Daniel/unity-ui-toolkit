using System.Collections.Generic;
using UnityEngine.UIElements;

namespace UI.FrameWork
{
	public abstract class AXmlController
	{
		public AXmlController Parent { get; private set; }
		public VisualElement XmlElement { get; private set; }
		public List<AXmlController> Children { get; private set; } = new List<AXmlController>();
		
		protected AXmlController(AXmlController parent, VisualElement xmlElement)
		{
			Parent = parent;
			XmlElement = xmlElement;
		}

		public virtual VisualElement Render()
		{
			XmlElement?.Clear();
			
			return XmlElement;
		}
	}
}