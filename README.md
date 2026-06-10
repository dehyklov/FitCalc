# FitCalc - Калькулятор калорій

### Архітектура системи
```mermaid
graph LR
    User[Користувач] -->|Вводить дані| UI(WinForms UI)
    UI -->|Передає вагу/час| Logic{Business Logic}
    Logic -->|Розрахунок MET| Result[Результат: ккал]
