# Recipe Search Application

## Programming Principles

1. **Single Responsibility Principle (SRP)**:
    - Each class in the code has a single responsibility. For example, `RecipeController` is responsible for managing the interactions between the view and the repository, `db` handles database connections, and each search strategy handles a specific type of search.

2. **Open/Closed Principle (OCP)**:
    - The code is designed to be open for extension but closed for modification. New search strategies can be added by implementing the `ISearchStrategy` interface and extending the `BaseSearchStrategy` class without modifying existing code.

3. **Liskov Substitution Principle (LSP)**:
    - Subclasses and implementations (e.g., `SearchByIdStrategy`, `SearchByNameStrategy`, `SearchByIngredientsStrategy`) can be used interchangeably with their base class (`BaseSearchStrategy`) and interface (`ISearchStrategy`) without altering the correctness of the program.

4. **Interface Segregation Principle (ISP)**:
    - The `ISearchStrategy` interface is lean, containing only the necessary method for searching, ensuring that classes implementing the interface are not forced to implement methods they do not use.

5. **Dependency Inversion Principle (DIP)**:
    - High-level modules like `RecipeController` depend on abstractions (`ISearchStrategy`) rather than concrete implementations, promoting flexibility and decoupling.

## Design Patterns
**Strategy Pattern**:
    - The strategy pattern is used to define a family of algorithms (search strategies) and make them interchangeable. The `ISearchStrategy` interface and the concrete strategy classes (`SearchByIdStrategy`, `SearchByNameStrategy`, `SearchByIngredientsStrategy`) implement this pattern.
**Singleton Pattern**:
    - The `RecipeRepository` class uses the singleton pattern to ensure that only one instance of the repository exists, providing a global point of access to the database.
**MVC (Model-View-Controller) Pattern
    - Model: Classes Recipe and RecipeRepository are responsible for data management.
    - View: Classes AllInfo and SearchForm are responsible for presenting data and interacting with the user.
    - Controller: The RecipeController class handles the logic between the model and the view.

## Refactoring Techniques
**Extract Method:
    - Methods like ExecuteSearch in BaseSearchStrategy are extracted to improve readability and reusability, encapsulating the common code for executing database queries.
**Encapsulate Field:
    - Direct access to fields is minimized by using properties (e.g., Recipe class properties) to control access and ensure encapsulation.
**Replace Conditional with Polymorphism:
    - The code replaces conditional logic for different search types with polymorphism. Different search behaviors are encapsulated in their respective strategy classes, and the appropriate strategy is selected based on user input.

## Code Walkthrough

### Strategy Pattern

- **Interface Definition**:
    ```csharp
    public interface ISearchStrategy
    {
        List<Recipe> Search(db database, string query);
    }
    ```

- **Abstract Base Class**:
    ```csharp
    public abstract class BaseSearchStrategy : ISearchStrategy
    {
        protected List<Recipe> ExecuteSearch(db database, string sqlQuery, Action<MySqlCommand> parameterSetter)
        {
            // code
        }

        public abstract List<Recipe> Search(db database, string query);
    }
    ```

- **Concrete Strategies**:
    ```csharp
    public class SearchByIdStrategy : BaseSearchStrategy
    {
        public override List<Recipe> Search(db database, string query)
        {
            string sqlQuery = "SELECT * FROM lab6 WHERE id = @query";
            return ExecuteSearch(database, sqlQuery, cmd => cmd.Parameters.AddWithValue("@query", query));
        }
    }

    public class SearchByNameStrategy : BaseSearchStrategy
    {
        public override List<Recipe> Search(db database, string query)
        {
            string sqlQuery = "SELECT * FROM lab6 WHERE title LIKE @query";
            return ExecuteSearch(database, sqlQuery, cmd => cmd.Parameters.AddWithValue("@query", "%" + query + "%"));
        }
    }

    public class SearchByIngredientsStrategy : BaseSearchStrategy
    {
        public override List<Recipe> Search(db database, string query)
        {
            string sqlQuery = "SELECT * FROM lab6 WHERE text LIKE @query";
            return ExecuteSearch(database, sqlQuery, cmd => cmd.Parameters.AddWithValue("@query", "%" + query + "%"));
        }
    }
    ```

### Singleton Pattern

- **Singleton Implementation**:
    ```csharp
    public class RecipeRepository
    {
        private static RecipeRepository instance;
        private db database;

        private RecipeRepository()
        {
            string connectionString = "Server=localhost;Database=recipes;Uid=root;Pwd=;";
            database = new db(connectionString);
        }

        public static RecipeRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RecipeRepository();
                }
                return instance;
            }
        }
        // code
    }
    ```
### MVC (Model-View-Controller) Pattern

- **Model**;

- **Recipe Class**: Represents the data structure of a recipe.
    ```csharp
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
    ```

- **RecipeRepository Class**: Handles database interactions and manages recipe data.
    ```csharp
    public class RecipeRepository
    {
        private static RecipeRepository instance;
        private db database;

        private RecipeRepository()
        {
            string connectionString = "Server=localhost;Database=recipes;Uid=root;Pwd=;";
            database = new db(connectionString);
        }

        public static RecipeRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RecipeRepository();
                }
                return instance;
            }
        }

        public List<Recipe> GetAllRecipes()
        {
            // code
        }

        public List<Recipe> SearchRecipes(ISearchStrategy searchStrategy, string query)
        {
            return searchStrategy.Search(database, query);
        }
    }
    ```

- **View**;

- **AllInfo Class**: Represents the view for displaying all recipe information.
    ```csharp
    public partial class AllInfo : Form
    {
        private RecipeController controller;

        public AllInfo()
        {
            InitializeComponent();
            controller = new RecipeController(this);
            InitializeDataGridView();
            LoadRecipes();
        }

        private void InitializeDataGridView()
        {
            // code
        }

        public void DisplayRecipes(List<Recipe> recipes)
        {
            dataGridView.DataSource = recipes;
        }

        private void LoadRecipes()
        {
            var recipes = controller.LoadRecipes();
            DisplayRecipes(recipes);
        }
    }
    ```

- **SearchForm Class**: Represents the view for searching recipes.
    ```csharp
    public partial class SearchForm : Form
    {
        private RecipeRepository repository;

        public SearchForm()
        {
            InitializeComponent();
            repository = RecipeRepository.Instance;
            SearchButton.Click += SearchButton_Click;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // code
        }
    }
    ```

- **Controller**;

- **RecipeController Class**: Manages interactions between the view and the repository.
    ```csharp
    public class RecipeController
    {
        private AllInfo view;
        private RecipeRepository repository;

        public RecipeController(AllInfo view)
        {
            this.view = view;
            repository = RecipeRepository.Instance;
        }

        public List<Recipe> LoadRecipes()
        {
            return repository.GetAllRecipes();
        }
    }
    ```
