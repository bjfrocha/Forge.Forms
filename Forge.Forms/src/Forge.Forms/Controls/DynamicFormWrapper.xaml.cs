﻿using System.Windows.Controls;

namespace Forge.Forms.Controls
{
    /// <summary>
    /// Interaction logic for FormWrapper.xaml
    /// </summary>
    public partial class DynamicFormWrapper : UserControl
    {
        public DynamicFormWrapper(object model, object context, DialogOptions options)
        {
            DataContext = options;
            InitializeComponent();
            Form.Environment.Add(options.EnvironmentFlags);
            Form.Context = context;
            Form.Model = model;
        }
    }
}
