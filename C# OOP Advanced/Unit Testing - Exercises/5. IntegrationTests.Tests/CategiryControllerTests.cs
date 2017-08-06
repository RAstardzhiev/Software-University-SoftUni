namespace _5.IntegrationTests.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using NUnit.Framework;
    using Integration_Tests.Controllers;
    using Integration_Tests.Models;
    using Integration_Tests.Interfaces;

    [TestFixture]
    public class CategiryControllerTests
    {
        private CategoryController categoryController;
        private HashSet<ICategory> categories;

        [SetUp]
        public void TestInit()
        {
            this.categoryController = new CategoryController();

            this.categories = (HashSet<ICategory>)this.categoryController.GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .First(f => f.Name == "categories")
                .GetValue(this.categoryController);
        }

        [Test]
        public void AddCategoryShouldSsaveTheCategory()
        {
            // Arrange
            var categoryName = "Category Name";

            // Act
            this.categoryController.AddCategory(categoryName);

            // Assert
            Assert.AreEqual(1, this.categories.Count, "Category is not saved the AddCategory");
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(30)]
        public void AddMoreThanOneCategoryShouldSaveAllOfThem(int numberOfCategories)
        {
            // Arrange
            var categoryName = "Test";

            // Act
            for (int i = 0; i < numberOfCategories; i++)
            {
                this.categoryController.AddCategory($"{categoryName} - {i}");
            }

            // Assert
            Assert.AreEqual(numberOfCategories, this.categories.Count, "Adding more than one category does not save them");
        }

        [Test]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(30)]
        public void AddMultipleCategoriesAtOneShouldSaveAllOfThem(int numberOfCategories)
        {
            // Arrange
            var categoryNames = new string[numberOfCategories];
            for (int i = 0; i < categoryNames.Length; i++)
            {
                categoryNames[i] = $"Test - {i}";
            }

            // Act
            this.categoryController.AddCategory(categoryNames);

            // Assert
            Assert.AreEqual(numberOfCategories, this.categories.Count, "Add categories whith collection of names doesn't save them correctly");
        }

        [Test]
        public void CanNotAddCategoryWithoutName()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => this.categoryController.AddCategory(""));
        }

        [Test]
        [TestCase(" ")]
        [TestCase("   ")]
        [TestCase("\t")]
        [TestCase("\r")]
        [TestCase("\n")]
        [TestCase("\r\n")]
        [TestCase("\n\r")]
        [TestCase(" \n \r \t \n\r \r\n")]
        public void CanNotAddCategoryWithBlankSpacesForName(string name)
        {
            // Assert
            Assert.Throws<ArgumentException>(() => this.categoryController.AddCategory(name));
        }

        [Test]
        public void AddChildShouldAssignAChildcategoryToTheParent()
        {
            // Arrange 
            var parentName = "Parent";
            this.categoryController.AddCategory(parentName);
            var parentCategory = this.categories.First(c => c.Name == parentName);

            // Act
            this.categoryController.AddChild(parentCategory, "Child");

            // Assert
            Assert.AreEqual(parentCategory.ChildCategories.Count, 1, "AddChild doesn't assign a child category to it's parent");
        }

        [Test]
        public void AddUserShouldAssignUserToASpecificCategory()
        {
            // Arrange
            var categoryName = "Test Category";
            this.categoryController.AddCategory(categoryName);
            var addedCategory = this.categories.First(c => c.Name == categoryName);

            // Act
            this.categoryController.AddUser(addedCategory, new User("User"));

            // Assert
            Assert.AreEqual(addedCategory.Users.Count, 1, "User is not assigned to the category");
        }

        [Test]
        public void AddUserShouldAssignTheCategoryToItsUserListOfCategories()
        {
            // Arrange
            var categoryName = "Category";
            this.categoryController.AddCategory(categoryName);
            var userName = "User";
            var user = new User(userName);

            // Act
            this.categoryController.AddUser(this.categories.First(), user);

            // Assert
            Assert.AreEqual(categoryName, user.Categories.First().Name, "Adding user to category does not add the category to the user's list of categories");
        }

        [Test]
        public void RemoveCategoryByNameShouldDeleteIt()
        {
            // Arrange
            var numberOfCategories = 10;
            var categoryname = "Test - {0}";
            for (int i = 0; i < numberOfCategories; i++)
            {
                this.categoryController.AddCategory(string.Format(categoryname, i));
            }

            // Act
            this.categoryController.RemoveCategory(string.Format(categoryname, 0));

            // Assert
            Assert.AreEqual(numberOfCategories - 1, this.categories.Count, "Remove doesn't delete the category");
        }

        [Test]
        [TestCase(2)]
        [TestCase(10)]
        [TestCase(20)]
        public void RemoveCategoryWithCollectionOfNameShouldDeleteThem(int numberOfDeletions)
        {
            // Arrange
            var numberOfCategories = numberOfDeletions + 5;
            var categoryname = "Test - {0}";
            for (int i = 0; i < numberOfCategories; i++)
            {
                this.categoryController.AddCategory(string.Format(categoryname, i));
            }

            var deletionNames = new string[numberOfDeletions];
            for (int i = 0; i < deletionNames.Length; i++)
            {
                deletionNames[i] = string.Format(categoryname, i);
            }

            // Act
            this.categoryController.RemoveCategory(deletionNames);

            // Assert
            Assert.AreEqual(numberOfCategories - deletionNames.Length, this.categories.Count, "Remove doesn't delete the category");
        }

        [Test]
        public void RemoveCategoryShoildRemoveItEvenWhenIsAChildToAnotherOne()
        {
            // Arrange
            var parentName = "Parent";
            var childName = "Child";
            this.categoryController.AddCategory(parentName);
            var parent = this.categories.First(c => c.Name == parentName);
            this.categoryController.AddChild(parent, childName);

            // Act
            this.categoryController.RemoveCategory(childName);

            // Assert
            Assert.AreEqual(0, this.categories.First().ChildCategories.Count, "Child category is not removed");
        }

        [Test]
        public void RemoveCategoryShouldMoveChildCategoriesToItsParentOne()
        {
            // Arrange
            var firstCategoryName = "First";
            var secondCategoryName = "First's child";
            var thirdCategoryName = "Second's child & First's sub-child";

            this.categoryController.AddCategory(firstCategoryName);
            var biggestParent = this.categories.First();
            this.categoryController.AddChild(biggestParent, secondCategoryName);
            this.categoryController.AddChild(biggestParent.ChildCategories.First(), thirdCategoryName);

            // Act
            this.categoryController.RemoveCategory(secondCategoryName);

            // Assert
            Assert.AreEqual(this.categories.First().ChildCategories.Count, 1, "Removing a category looses all of its subb-categories");
            Assert.AreEqual(
                thirdCategoryName,
                this.categories.First().ChildCategories.First().Name, 
                "Removing a category doesn't assign the correct childrent to the parent of the removed one");
        }

        [Test]
        public void RemoveCategoryShouldAssignAllOfItsUsersToItsParent()
        {
            // Act
            this.RemoveChildCategoryContainingUser();

            // Assert
            Assert.AreEqual(1, this.categories.First().Users.Count(), "Users are not transferred to the parent category in the process of removing");
        }

        [Test]
        public void RemoveCategoryShouldChangeItsUsersCorespondingRelationWithTheParentCategory()
        {
            // Act
            this.RemoveChildCategoryContainingUser();

            // Assert
            Assert.AreEqual(
                this.categories.First().Name, 
                this.categories.First().Users.First().Categories.First().Name, 
                "Removing category doesn't change its relations with its users");
        }

        [Test]
        public void RemoveCategoryShouldRemoveItselfFromItsUsersLists()
        {
            // Arrange
            var categoryName = "Category";
            this.categoryController.AddCategory(categoryName);
            var category = this.categories.First();
            var user = new User("User");
            this.categoryController.AddUser(category, user);

            // Act
            this.categoryController.RemoveCategory(categoryName);

            //
            Assert.AreEqual(0, user.Categories.Count(), "Removing category without a parent must remove itself from its users lists");
        }

        private void RemoveChildCategoryContainingUser()
        {
            var parentCategoryName = "Parent Category";
            var childCategoryName = "Child Category";
            this.categoryController.AddCategory(parentCategoryName);
            this.categoryController.AddChild(this.categories.First(), childCategoryName);

            var userName = "User's Name";
            var childCategody = this.categories.First().ChildCategories.First();
            this.categoryController.AddUser(childCategody, new User(userName));

            this.categoryController.RemoveCategory(childCategoryName);
        }
    }
}
