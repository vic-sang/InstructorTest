using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using instructor.Data;
using instructor.Models;

namespace instructor.Tests;

public class DataAccessLayerTest
{
        [Fact]
        public async Task AddInstructorAsync_InstructorIsAdded()
        {
            using (var db = new InstructorTestContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var recId = 10;
                var expectedGrades = new Instructor();


                var expectedInstructor = new Instructor() 
                { 
                    ID = recId, 
                    Grades = 100
                    
                };

                // Act
                await db.AddInstructorAsync(expectedInstructor);

                // Assert
                var actualInstructor = await db.FindAsync<Instructor>(recId);
                Assert.Equal(expectedInstructor, actualInstructor);
            }
        }
        [Fact]
    public void ProvideGrades()
    {
        using (var db = new InstructorTestContext(Utilities.TestDbContextOptions()))
        {
                //Arrange
            var expectedProvideGrades = new Instructor();
           
            

            
        }
    } 
}