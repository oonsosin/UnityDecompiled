using System;
using UnityEngine;

namespace UnityEditorInternal
{
	public struct NativeProfilerTimeline_InitializeArgs
	{
		public Color[] profilerColors;

		public Color allocationSampleColor;

		public Color internalSampleColor;

		public float ghostAlpha;

		public float nonSelectedAlpha;

		public IntPtr guiStyle;

		public float lineHeight;

		public float textFadeOutWidth;

		public float textFadeStartWidth;

		public void Reset()
		{
			this.profilerColors = null;
			this.allocationSampleColor = Color.clear;
			this.internalSampleColor = Color.clear;
			this.ghostAlpha = 0f;
			this.nonSelectedAlpha = 0f;
			this.guiStyle = (IntPtr)0;
			this.lineHeight = 0f;
			this.textFadeOutWidth = 0f;
			this.textFadeStartWidth = 0f;
		}
	}
}
