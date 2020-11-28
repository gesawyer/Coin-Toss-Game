//Create references to HTML elements
let updateBudgetButton = document.querySelector("#update_budget");
let addExpenseButton = document.querySelector("#add_expense");
let monthlyBudget = document.querySelector("#monthly_budet");
let incomeInput = document.querySelector("#income_input");
let remainingBalance = document.querySelector("#remaining_balance");
let amountInput = document.querySelector("#amount_input");
let nameInput = document.querySelector("#name_input");
let expenseList = document.querySelector("#total_expenses");




updateBudgetButton.onclick = updateBudget;
//addExpenseButton.onclick = addExpense; 


let monthlyIncome= 0;
let expenses = [];
let expenseTotaly = 0;
let balance = 0;


//build a function that retrieves the value entered into the monthly income input

function updateBudget(event) {
    event.preventDefault();
    console.log("Update Budget fired.");
}