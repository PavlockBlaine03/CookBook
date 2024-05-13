using DataAccessLayer.Contracts;
using Microsoft.Extensions.DependencyInjection;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Models;

namespace CookBook.UI
{
    public partial class RecipeTypesForm : Form
    {
        private readonly IRecipeTypesRepository _recipeTypesRepository;
        public RecipeTypesForm(IRecipeTypesRepository recipeTypesRepository)
        {
            InitializeComponent();
            _recipeTypesRepository = recipeTypesRepository;
            _recipeTypesRepository.OnError += (errorMessage) => MessageBox.Show(errorMessage);
        }
        private async void RefreshRecipeTypesList()
        {
            RecipeTypesLbx.DataSource = await _recipeTypesRepository.GetRecipeTypes();
            RecipeTypesLbx.DisplayMember = "Name";
        }

        private void RecipeTypesForm_Load(object sender, EventArgs e)
        {
            RefreshRecipeTypesList();
        }

        private async void AddRecipeTypeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewTypeTxt.Text))
                return;

            RecipeType newRecipeType = new RecipeType(NewTypeTxt.Text);

            await _recipeTypesRepository.AddRecipeType(newRecipeType);
            RefreshRecipeTypesList();
            NewTypeTxt.Text = "";
        }
    }
}
