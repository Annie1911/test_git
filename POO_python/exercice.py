# This is a sample Python script.

# Press Maj+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.


class Etudiant:

    def __int__(self,nom:str,note1:float,note2:float):
        self.nom=nom
        self.note1=note1
        self.note2=note2
    def calc_moy(self):
      moy = (self.note1 + self.note)/2
      return moy

    def afficher(self):
        print(f"le nom :{self.nom}")
        print(f"la moyenne:{self.calc_moy()}")


if __name__ == "__main__":
    nom = input ("entrz votre nom :")
    note1 =float(input("entrez également votre note1 :"))
    note2 = float(input("et également votre note2 : "))

etudiant =Etudiant(nom,note1,note2)
print(etudiant)
