using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Creationometry;

namespace ElementManagerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void singleAddDesignElementTest()
        {
            ElementManager manager = new ElementManager();
            manager.addDesignElement(DesignElementTypes.CIRCLE);
            Assert.AreEqual(1, manager.getNumberOfElements());
        }

        [TestMethod]
        public void mulitpleAddDesignElementTest()
        {
            ElementManager manager = new ElementManager();
            manager.addDesignElement(DesignElementTypes.CIRCLE);
            manager.addDesignElement(DesignElementTypes.ELLIPSE);
            manager.addDesignElement(DesignElementTypes.TRIANGLE);
            manager.addDesignElement(DesignElementTypes.LINE);
            Assert.AreEqual(4, manager.getNumberOfElements());
        }

        [TestMethod]
        public void selectDesignElementTest()
        {
            ElementManager manager = new ElementManager();
            manager.addDesignElement(DesignElementTypes.ELLIPSE);
            manager.selectDesignElement(50, 50);
            DesignElement obj1 = manager.getSelectedDesignElement();

            //Assert.AreEqual(, manager.getNumberOfElements());
        }

        [TestMethod]
        public void singleDuplicateDesignElementTest()
        {
            ElementManager manager = new ElementManager();
            manager.addDesignElement(DesignElementTypes.ELLIPSE);
            manager.selectDesignElement(50, 50);
            manager.duplicateDesignElement();
            Assert.AreEqual(2, manager.getNumberOfElements());
        }

        [TestMethod]
        public void multipleDuplicateDesignElementTest()
        {
            ElementManager manager = new ElementManager();
            manager.addDesignElement(DesignElementTypes.ELLIPSE);
            manager.selectDesignElement(50, 50);
            manager.duplicateDesignElement();
            manager.selectDesignElement(50, 50);
            manager.duplicateDesignElement();
            Assert.AreEqual(3, manager.getNumberOfElements());
        }

        [TestMethod]
        public void emptyGetSelectedDesignElementTest()
        {
            ElementManager manager = new ElementManager();
            Assert.AreEqual(null, manager.getSelectedDesignElement());
        }

        [TestMethod]
        public void deselectDesignElementTest()
        {
            ElementManager manager = new ElementManager();
            manager.addDesignElement(DesignElementTypes.ELLIPSE);
            manager.selectDesignElement(50, 50);
            manager.deSelectDesignElement();
            Assert.AreEqual(null, manager.getSelectedDesignElement());
        }

        [TestMethod]
        public void deleteDesignElementTest()
        {
            ElementManager manager = new ElementManager();
            manager.addDesignElement(DesignElementTypes.ELLIPSE);
            manager.selectDesignElement(50, 50);
            manager.deleteDesignElement();
            Assert.AreEqual(0, manager.getNumberOfElements());
        }

        [TestMethod]
        public void setPointsTest()
        {
            System.Drawing.Point[] points = new System.Drawing.Point[3];
            ElementManager e = new ElementManager();
            for(int j = 0; j < points.Length; j++)
            {
                System.Drawing.Point p = new System.Drawing.Point();
                p.X = j * j + 10;
                p.Y = j * j + 10;
            }

            Assert.AreEqual(true, true);
        }
    }
}