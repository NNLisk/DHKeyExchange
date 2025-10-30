# DIFFIE-HELLMAN KEY EXCHANGE

+ Simple C# utility class for secret key copmputing
+ Uses modulo operations to compute a secret shared key between two cooperating clienthosts
+ For personal use only, NOT EXTERNALLY VERIFIED

# How it works

+ REQUIREMENT: .NET SDK Runtime, version 6 or later
+ static utility class, call functions directly after incorporating to the filestructure

# DIFFIE-HELLMAN logic

+ two clients agree on a modulus and a generator g, both in this implementation globally fixed. Modulus is a safe 4096 bits long prime number provided by the Request for comments (RFC) 3526 and generator is 2. 

Both clients generate a random private key using `BigInteger pk = GeneratePrivateKey()`
+ based on implementation can be chat specific or even message specific

Both clients compute public key using `BigInteger public key = ComputePublicKey(BigInteger privateKey)`

These public keys are exchanged between clients

using the foreign public key, domestic private key the client uses `ComputeSharedSecret(BigInteger fpk, BigInteger dpk)`
+ Both parties have computed a shared private key

---

Diffie hellman created keys can be used in the actual end-to-end encryption process
