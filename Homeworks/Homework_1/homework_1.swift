/*
Создать иерархию классов и протокол, который будет реализовывать один из наследников. 
Залить код в репозиторий гитхаба / прикрепить в открытый гугл документ с сохранением всех отступов

Например, можно создать класс "Фигура", наследником которого будут фигуры (треугольник, круг, прямоугольник). 
У этого класса будут read-only переменные name и cornerRadius, которые надо будет переопределить в наследниках. 
Также каждый наследник должен иметь метод расчета площади. Протокол будет создан для четырехугольных фигур, стороны 
которых попарно равны (прямоугольник, квадрат, параллелограм, параллелограмм). В нем будут переменные "ширина", 
"длина" и "Периметр" (переменная периметр должна иметь стандартную реализацию).
*/



import Foundation

class Figure {
    var name: String {
        return "Figure"
    }
}

class Triangle : Figure {
    
    override var name: String {
        return "Треугольник"
    }
    
    let a: Double
    let b: Double
    let c: Double
    var Perimeter: Double {
        return a + b + c
    }
    
    init(a: Double, b: Double, c: Double) {
        self.a = a
        self.b = b
        self.c = c
    }
}

class Circle : Figure {
    override var name: String {
        return "Круг"
    }
    
    let radius: Double
    var Perimeter: Double {
        return  2 * 3.14 * radius
    }
    
    init(radius: Double) {
        self.radius = radius
    }
}

protocol Quadrangles {
    
    var a: Double { get }
    var b: Double { get }
}

extension Quadrangles {
    var Perimeter: Double {
        return 2*a + 2*b
    }
}

class Rectangle : Figure, Quadrangles {
    override var name: String {
        return "Прямоугольник"
    }
    
    let a: Double
    let b: Double
    
    init( a: Double, b: Double) {
        self.a = a
        self.b = b
    }
}

class Parallelogram : Figure, Quadrangles {
    override var name: String {
        return "Параллелограмм"
    }
    
    let a: Double
    let b: Double
    
    init( a: Double, b: Double) {
        self.a = a
        self.b = b
    }
}

    var T = Triangle(a: 7, b: 6, c: 2)
    print("У фигуры:", T.name, "периметр = ", T.Perimeter)

    let C = Circle(radius: 5)
    print("У фигуры:", C.name, "периметр = ", C.Perimeter)

    let R = Rectangle( a: 3, b: 5)
    print("У фигуры:", R.name, "периметр = ", R.Perimeter)

    let P = Parallelogram( a: 4, b: 4)
    print("У фигуры:", P.name, "периметр = ", P.Perimeter)