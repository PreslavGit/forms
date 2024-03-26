using ProjectWFA.Grade;
using ProjectWFA.Student;
using ProjectWFA.Subject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWFA
{
    public partial class Form1 : Form
    {
        public Configurator Configurator;
        public Form1(Configurator config)
        {
            InitializeComponent();
            this.Configurator = config;
        }

        private void specialtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpecialty fSpecialty = new FormSpecialty(this.Configurator);
            fSpecialty.ShowDialog();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubject fSubject = new FormSubject(this.Configurator);
            fSubject.ShowDialog();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent fStudent = new FormStudent(this.Configurator);
            fStudent.ShowDialog();
        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrade fGrade = new FormGrade(this.Configurator);
            fGrade.ShowDialog();
        }

        private void specialtyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormViewSpecialty fViewSpecialty = new FormViewSpecialty(this.Configurator);
            fViewSpecialty.ShowDialog();
        }

        private void subjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormViewSubject form = new FormViewSubject(this.Configurator);
            form.ShowDialog();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormViewStudent form = new FormViewStudent(this.Configurator);
            form.ShowDialog();
        }

        private void gradeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormViewGrade form = new FormViewGrade(this.Configurator);
            form.ShowDialog();
        }
    }
}
