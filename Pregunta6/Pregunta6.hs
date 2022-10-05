suma :: Integer -> Integer-> Integer
suma a b = a + b
resta :: Integer -> Integer -> Integer
resta a b = a - b
multi :: Integer -> Integer -> Integer
multi a b = a * b
divide :: Integer -> Integer -> Integer
divide a b = div  a  b
main = do
    putStr "La suma es:"
    print (suma 8 14)
    putStr "La resta es:"
    print (resta 15 20)
    putStr "La multiplicación es:"
    print (multi 7 6)
    putStr "La división es:"
    print (divide 50 6)