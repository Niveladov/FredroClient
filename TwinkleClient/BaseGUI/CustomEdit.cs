using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.Client.BaseGUI
{
    //The attribute that points to the registration method
    [UserRepositoryItem("RegisterCustomEdit")]
    public class RepositoryItemCustomEdit : RepositoryItemButtonEdit
    {

        //The static constructor which calls the registration method
        static RepositoryItemCustomEdit() { RegisterCustomEdit(); }

        //Initialize new properties
        public RepositoryItemCustomEdit()
        {
            useDefaultMode = true;
        }

        //The unique name for the custom editor
        public const string CustomEditName = "CustomEdit";

        //Return the unique name
        public override string EditorTypeName { get { return CustomEditName; } }

        //Register the editor
        public static void RegisterCustomEdit()
        {
            //Icon representing the editor within a container editor's Designer
            Image img = null;
            try
            {
                img = (Bitmap)Bitmap.FromStream(Assembly.GetExecutingAssembly().
                  GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp"));
            }
            catch
            {
            }
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName,
              typeof(CustomEdit), typeof(RepositoryItemCustomEdit),
              typeof(ButtonEditViewInfo), new ButtonEditPainter(), true, img));
        }

        //A custom property
        private bool useDefaultMode;

        public bool UseDefaultMode
        {
            get { return useDefaultMode; }
            set
            {
                if (useDefaultMode != value)
                {
                    useDefaultMode = value;
                    OnPropertiesChanged();
                }
            }
        }

        //Override the Assign method
        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemCustomEdit source = item as RepositoryItemCustomEdit;
                if (source == null) return;
                useDefaultMode = source.UseDefaultMode;
            }
            finally
            {
                EndUpdate();
            }
        }
        public override BaseEditViewInfo CreateViewInfo()
        {
            return new CustomViewInfo(this);
        }
    }

    [ToolboxItem(true)]
    public class CustomEdit : ButtonEdit
    {

        //The static constructor which calls the registration method
        static CustomEdit() { RepositoryItemCustomEdit.RegisterCustomEdit(); }

        //Initialize the new instance
        public CustomEdit() { }

        //Return the unique name
        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemCustomEdit.CustomEditName;
            }
        }

        //Override the Properties property
        //Simply type-cast the object to the custom repository item type
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomEdit Properties
        {
            get { return base.Properties as RepositoryItemCustomEdit; }
        }

    }

    public class CustomViewInfo : ButtonEditViewInfo
    {
        public CustomViewInfo(RepositoryItem item) : base(item) { }
        protected override Color NullValuePromptForeColor
        {
            get
            {
                return Color.LightSkyBlue;
            }
        }
        public override DevExpress.Utils.AppearanceObject PaintAppearance
        {
            get
            {
                if (this.OwnerEdit.EditValue == null && this.DisplayText != string.Empty)
                    base.PaintAppearance.Font = new Font(this.Appearance.Font, FontStyle.Bold);
                return base.PaintAppearance;
            }
            set
            {
                base.PaintAppearance = value;
            }
        }
    }
}
