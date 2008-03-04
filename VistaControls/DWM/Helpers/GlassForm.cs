﻿/*****************************************************
 *            Vista Controls for .NET 2.0
 * 
 * http://www.codeplex.com/vistacontrols
 * 
 * @author: Lorenz Cuno Klopfenstein
 * Licensed under Microsoft Community License (Ms-CL)
 * 
 *****************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace VistaControls.DWM.Helpers {
	public class GlassForm : Form {

		public GlassForm() {
			this.ResizeRedraw = true;
		}

		#region Properties

		Margins _glassMargins = new Margins(0);

		[Description("The glass margins which are extended inside the client area of the window."), Category("Appearance"), DefaultValue(null)]
		/// <summary>Gets or sets the glass margins of the form.</summary>
		public Margins GlassMargins {
			get {
				return _glassMargins;
			}
			set {
				_glassMargins = value;

				SetGlass();
			}
		}

		#endregion

		#region Overriding

		bool _tracking = false;
		Point _lastPos;

		protected override void OnMouseMove(MouseEventArgs e) {
			if (_tracking) {
				Point screen = this.PointToScreen(e.Location);

				Point diff = new Point(screen.X - _lastPos.X, screen.Y - _lastPos.Y);

				Point loc = this.Location;
				loc.Offset(diff);
				this.Location = loc;

				_lastPos = screen;
			}

			base.OnMouseMove(e);
		}

		protected override void OnMouseUp(MouseEventArgs e) {
			if (e.Button == MouseButtons.Left)
				_tracking = false;

			base.OnMouseUp(e);
		}

		protected override void OnMouseDown(MouseEventArgs e) {
			if (e.Button == MouseButtons.Left) {
				if (_glassMargins.IsMarginless || (
						e.X <= _glassMargins.Left ||
						e.X >= this.ClientSize.Width - _glassMargins.Right ||
						e.Y <= _glassMargins.Top ||
						e.Y >= this.ClientSize.Height - _glassMargins.Bottom)
					) {
					_tracking = true;
					_lastPos = this.PointToScreen(e.Location);
				}
			}

			base.OnMouseDown(e);
		}

		protected override void OnPaint(PaintEventArgs e) {
			base.OnPaint(e);

			//Paint glass regions in black
			if (!_glassMargins.IsNull) {
				if (_glassMargins.IsMarginless)
					e.Graphics.Clear(Color.Black);
				else {
					e.Graphics.FillRectangles(Brushes.Black, new Rectangle[] {
					new Rectangle(0, 0, ClientSize.Width, _glassMargins.Top),
					new Rectangle(ClientSize.Width - _glassMargins.Right, 0, _glassMargins.Right, ClientSize.Height),
					new Rectangle(0, ClientSize.Height - _glassMargins.Bottom, ClientSize.Width, _glassMargins.Bottom),
					new Rectangle(0, 0, _glassMargins.Left, ClientSize.Height)
				});
				}
			}
		}

		#endregion

		private void SetGlass() {
			if (!_glassMargins.IsNull)
				DWMManager.EnableGlassFrame(this, _glassMargins);
			else
				DWMManager.DisableGlassFrame(this);

			this.Invalidate();
		}

	}
}