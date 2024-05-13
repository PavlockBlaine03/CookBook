using System.Reflection;
using CookBook.Helpers;
using DataAccessLayer.Contracts;
using DataAccessLayer.Repositories;
using DomainModel.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.CustomQueryResults;

namespace CookBook.UI
{
    public partial class RecipesForm : Form
    {
        private readonly IRecipeTypesRepository _recipeTypesRepository;
        private readonly IRecipesRepository _recipesRepository;
        private readonly IServiceProvider _serviceProvider;

        private bool _isUserImageAdded = false;
        private int _recipeToEditId;

        private Image _placeholderImage
        {
            get
            {
                var executingAssemblyLocation = Path.GetDirectoryName
                    (Assembly.GetExecutingAssembly().Location);
                var imagePath = Path.Combine(executingAssemblyLocation, "Assets\\Images\\recipe_placeholder_image.png");
                return Image.FromFile(imagePath);
            }
        }

        public RecipesForm(IRecipeTypesRepository recipeTypesRepository, IServiceProvider serviceProvider, IRecipesRepository recipesRepository)
        {
            InitializeComponent();
            _recipeTypesRepository = recipeTypesRepository;
            _serviceProvider = serviceProvider;
            _recipesRepository = recipesRepository;
            _recipesRepository.OnError += (errorMessage) => MessageBox.Show(errorMessage);
            _recipeTypesRepository.OnError += (errorMessage) => MessageBox.Show(errorMessage);
        }
        private async void RefreshRecipeTypes()
        {
            RecipeTypeCbx.DataSource = await _recipeTypesRepository.GetRecipeTypes();
            RecipeTypeCbx.DisplayMember = "Name";
        }

        private void RecipesForm_Load(object sender, EventArgs e)
        {
            CustomizeGridAppearance();
            RefreshRecipeTypes();
            RefreshGridData();
            RecipePictureBox.Image = _placeholderImage;
            RecipePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            AddRecipeBtn.Visible = true;
            EditRecipeBtn.Visible = false;
        }
        private void AddRecipeTypeBtn_Click(object sender, EventArgs e)
        {
            RecipeTypesForm form = _serviceProvider.GetRequiredService<RecipeTypesForm>();
            form.FormClosed += (sender, e) => RefreshRecipeTypes();
            form.ShowDialog();
        }
        private void ClearAllFields()
        {
            NameTxt.Text = string.Empty;
            DescriptionTxt.Text = string.Empty;
            RecipePictureBox.ImageLocation = string.Empty;
            RecipePictureBox.Image = _placeholderImage;
            _isUserImageAdded = false;
        }
        private bool IsValid()
        {
            bool isValid = true;
            string message = string.Empty;

            if (string.IsNullOrEmpty(NameTxt.Text))
            {
                isValid = false;
                message += "Please enter name.\n\n";
            }
            if (string.IsNullOrEmpty(DescriptionTxt.Text))
            {
                isValid = false;
                message += "Must have a description.\n\n";
            }
            if (!isValid)
                MessageBox.Show(message, "Form not valid!");
            return isValid;
        }
        private async void AddRecipeBtn_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;

            byte[] image = null;
            if (_isUserImageAdded)
                image = ImageHelper.ConvertToDbImage(RecipePictureBox.ImageLocation);

            int recipeTypeId = ((RecipeType)RecipeTypeCbx.SelectedItem).Id;
            Recipe newRecipe = new Recipe(NameTxt.Text, DescriptionTxt.Text, image, recipeTypeId);

            await _recipesRepository.AddRecipe(newRecipe);
            ClearAllFields();
            RefreshGridData();
        }

        private void CustomizeGridAppearance()
        {
            RecipesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RecipesGrid.AutoGenerateColumns = false;

            DataGridViewColumn[] columns = new DataGridViewColumn[6];
            columns[0] = new DataGridViewTextBoxColumn() { DataPropertyName = "Id", Visible = false };
            columns[1] = new DataGridViewTextBoxColumn() { DataPropertyName = "Name", HeaderText = "Name" };
            columns[2] = new DataGridViewTextBoxColumn() { DataPropertyName = "Type", HeaderText = "Type" };
            columns[3] = new DataGridViewTextBoxColumn() { DataPropertyName = "Description", HeaderText = "Description" };
            columns[4] = new DataGridViewButtonColumn()
            {
                Text = "Edit",
                Name = "EditBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };
            columns[5] = new DataGridViewButtonColumn()
            {
                Text = "Delete",
                Name = "DeleteBtn",
                HeaderText = "",
                UseColumnTextForButtonValue = true
            };
            RecipesGrid.RowHeadersVisible = false;
            RecipesGrid.Columns.Clear();
            RecipesGrid.Columns.AddRange(columns);

        }
        private async void RefreshGridData()
        {
            RecipesGrid.DataSource = await _recipesRepository.GetRecipes();
        }

        private void RecipePictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Please select an image",
                Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg",
                Multiselect = false
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RecipePictureBox.ImageLocation = openFileDialog.FileName;
                    _isUserImageAdded = true;
                }
            }
        }

        private void ClearAllFieldsBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private async void RecipesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && RecipesGrid.CurrentCell is DataGridViewButtonCell)
            {
                RecipeWithType clickedRecipe = (RecipeWithType)RecipesGrid.Rows[e.RowIndex].DataBoundItem;

                if (RecipesGrid.CurrentCell.OwningColumn.Name == "DeleteBtn")
                {
                    await _recipesRepository.DeleteRecipe(clickedRecipe.Id);
                    RefreshGridData();
                }
                else if (RecipesGrid.CurrentCell.OwningColumn.Name == "EditBtn")
                {
                    FillFormForEdit(clickedRecipe);
                }
            }
        }
        private void FillFormForEdit(RecipeWithType clickedRecipe)
        {
            NameTxt.Text = clickedRecipe.Name;
            DescriptionTxt.Text = clickedRecipe.Description;
            if (clickedRecipe.Image != null)
                RecipePictureBox.Image = ImageHelper.ConvertFromDbImage(clickedRecipe.Image);
            else
                RecipePictureBox.Image = _placeholderImage;

            AddRecipeBtn.Visible = false;
            EditRecipeBtn.Visible = true;
        }

        //private async void EditRecipeBtn_Click(object sender, EventArgs e)
        //{
        //    if (!IsValid())
        //        return;

        //    Recipe recipe = new Recipe(NameTxt.Text, DescriptionTxt.Text, null, _recipeToEditId);

        //    await _recipesRepository.EditRecipe(recipe);
        //    //string text = SearchTxt.Text;
        //    ClearAllFields();
        //    //SearchTxt.Text = text;
        //    RefreshGridData();

        //    EditRecipeBtn.Visible = false;
        //    AddRecipeBtn.Visible = true;

        //    _recipeToEditId = 0;
        //}
    }
}
