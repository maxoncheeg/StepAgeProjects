using System;

namespace SHARPex15_1
{
    [Serializable]
    class Cat   
    {
        private System.Drawing.Image _image;

        public string Name { get; set; }
        public System.Drawing.Image Image { get => _image; }

        private Cat(System.Drawing.Image _image, string Name)
        {
            this._image = _image;
            this.Name = Name;
        }
        public static Cat CreateCat(System.Drawing.Image image, string name) => 
            new Cat(image, name);

        public void Show(System.Windows.Forms.Label label, System.Windows.Forms.PictureBox pictureBox)
        {
            pictureBox.Image = _image;
            label.Text = $"{Name} Cat";
        }
    }
}
