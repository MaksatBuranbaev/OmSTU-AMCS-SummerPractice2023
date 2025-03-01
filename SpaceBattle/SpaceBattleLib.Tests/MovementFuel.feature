Функция: Движения только при достаточном количестве топлива
    
    Сценарий: Если топлива достаточно, то перемещение по прямой возможно
        Дано космический корабль имеет топливо в объеме 40 ед
        И имеет скорость расхода топлива при движении 2 ед
        Когда происходит прямолинейное равномерное движение без деформации
        Тогда новый объем топлива космического корабля равен 38 ед 


    Сценарий: Если недостаточно количества топлива, то перемещение по прямой невозможно
        Дано космический корабль имеет топливо в объеме 1 ед
        И имеет скорость расхода топлива при движении 2 ед
        Когда происходит прямолинейное равномерное движение без деформации
        Тогда возникает ошибка Exception