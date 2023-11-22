class Point:

    def __int__(self , x:float, y:float):
        self.__x = x
        self.__y = y

    def deplace(self,dx,dy):
        self.setX( self.getX +dx)
        self.setY (self.getY() +dy)


    def setX(self, otherX ):
        self.__x = otherX

    def getX(self):
        return self.__x

    def setY(self,o):
        self.__x = o

    def getY(self):
        return self.__y
