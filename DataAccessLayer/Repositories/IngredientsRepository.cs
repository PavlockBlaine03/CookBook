using Dapper;
using DataAccessLayer.Contracts;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class IngredientsRepository : IIngredientsRepository
    {
        public event Action<string> OnError;
        Logger _log = new Logger();
        public async Task AddIngredient(Ingredient ingredient)
        {
            try
            {
                string query = @"insert into Ingredients 
                (Name, Weight, KcalPer100g, PricePer100g, Type) 
                values (@Name, @Weight, @KcalPer100g, @PricePer100g, @Type)";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, ingredient);
                }
            }
            catch (SqlException ex)
            {
                string errorMessage;
                if(ex.Number == 2627)
                    errorMessage = "That ingredient already exists!";
                else
                    errorMessage = "An error happened in the database.";

                ErrorOccured(errorMessage, ex);
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while adding ingredient.";
                ErrorOccured(errorMessage, ex);
            }
        }
        private void ErrorOccured(string errorMessage, Exception ex)
        {
            OnError?.Invoke(errorMessage);
            _log.LogError(ex.Message, DateTime.Now);
        }
        public async Task<List<Ingredient>> GetIngredients(string? name="")
        {
            try
            {
                string query = "select * from Ingredients";
                if (!string.IsNullOrEmpty(name))
                {
                    query += $" where Name like '{name}%'";
                }

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    return (await connection.QueryAsync<Ingredient>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while getting ingredients.";
                ErrorOccured(errorMessage, ex);
                return new List<Ingredient>();
            }
        }

        public async Task DeleteIngredient(Ingredient ingredient)
        {
            try
            {
                string query = @$"delete from Ingredients where id = {ingredient.Id}";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while deleting ingredient.";
                ErrorOccured(errorMessage, ex);
            }
        }
        public async Task EditIngredient(Ingredient ingredient)
        {
            try
            {
                string query = @"update Ingredients
                            set
                            Name = @Name,
                            Weight = @Weight,
                            KcalPer100g = @KcalPer100g,
                            PricePer100g = @PricePer100g,
                            Type = @Type 
                            where Id = @Id";

                using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString))
                {
                    await connection.ExecuteAsync(query, ingredient);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error happened while editing ingredient.";
                ErrorOccured(errorMessage, ex);
            }
        }
    }
}