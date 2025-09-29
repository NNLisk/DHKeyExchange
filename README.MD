# DIFFIE-HELLMAN KEY EXCHANGE

+ Simple C# utility class for simple key exchange
+ For personal use only, not externally verified
+ Built to be used in server-client chatserver over TCP

# How it works

+ REQUIREMENT: .NET SDK Runtime, version 6 or later
+ Either call this utility class according to "Logic" or try it with program in terminal
+ If used for between clients then of course requires a program that is able to sent data over TCP

# DIFFIE-HELLMAN logic

+ two clients agree on a modulus and a generator g, both in this implementation globally fixed. Modulus is a safe 4096 bits long\nprime number provided by the Request for comments (RFC) 3526 and generator is 2. 

Both clients generate a random private key using 
    `BigInteger pk = GeneratePrivateKey()`
+ based on implementation can be chat specific or even message specific

Both clients generate a public key according to g^privateKey
