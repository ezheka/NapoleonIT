//Расширение для Double, которое переводит единицы измерения в сантиметры

extension Double {
    var mm: Double { return self / 10.0 }
    var dm: Double { return self * 10.0 }
    var m: Double { return self * 100.0 }
    var km: Double { return self * 100000 }
    var inc: Double { return self * 2.54 }
}

let fiftyMillimeter = 50.mm
print("50 Миллиметров = \(fiftyMillimeter) сантиметров")

let oneDecimeter = 1.dm
print("1 Дециметр = \(oneDecimeter) сантиметров")

let tenMetres = 10.m
print("10 Метров = \(tenMetres) сантиметров")

let twoKilometers = 2.km
print("2 Километра = \(twoKilometers) сантиметров")

let twentyFiveInches = 25.inc
print("25 Дюймов = \(twentyFiveInches) сантиметров")