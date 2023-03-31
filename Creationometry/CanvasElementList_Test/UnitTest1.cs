using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Creationometry;
using Creationometry.Presenters;
using System.Windows.Forms;
using Creationometry.Views.EMMenu;

namespace CanvasElementList_Test
{
    //------------------------------------------------------------------
    // Name:    Megan Baxter
    // Project: Creationometry
    // Purpose: This Test will test the methods of the CanvasElementList
    //          Class. All methods are covered in this test, except
    //          the method for displaying the elements in the list. This
    //          method is covered by GUI testing.
    //------------------------------------------------------------------
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void paramConstructorTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            Panel Canvas = new Panel();
            EllipseModMenuView ellipseModMenuView1 = new EllipseModMenuView();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            EMMenuPresenterManager eMMenuPresenterManager = new EMMenuPresenterManager(ellipseModMenuView1,
                Canvas, commandSelector);
            Panel borderPanel = new Panel();
            CanvasElementList objList = new CanvasElementList(eMMenuPresenterManager, borderPanel);

            Assert.AreEqual(true, objList.getEMMenuPresenterManager() == eMMenuPresenterManager);
        }

        [TestMethod]
        public void emptyIsEmptyTest()
        {
            CanvasElementList objList = new CanvasElementList();
            Assert.AreEqual(true, objList.isEmpty());
        }

        [TestMethod]
        public void notEmptyIsEmptyTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            Assert.AreEqual(false, objList.isEmpty());
        }

        [TestMethod]
        public void emptyGetListSizeTest()
        {
            CanvasElementList objList = new CanvasElementList();
            Assert.AreEqual(0, objList.getListSize());
        }

        [TestMethod]
        public void notEmptyGetListSizeTest()
        {
            DesignElement obj1 = new Ellipses();
            DesignElement obj2 = new Ellipses();
            DesignElement obj3 = new Ellipses();
            DesignElement obj4 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            objList.addElement(obj2);
            objList.addElement(obj3);
            objList.addElement(obj4);
            Assert.AreEqual(4, objList.getListSize());
        }

        [TestMethod]
        public void emptyGetIndexTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            Assert.AreEqual(-1, objList.getIndex(obj1));
        }

        [TestMethod]
        public void singleGetIndexTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            Assert.AreEqual(0, objList.getIndex(obj1));
        }

        [TestMethod]
        public void multipleGetIndexTest()
        {
            DesignElement obj1 = new Ellipses();
            DesignElement obj2 = new Ellipses();
            DesignElement obj3 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            objList.addElement(obj2);
            objList.addElement(obj3);
            Assert.AreEqual(1, objList.getIndex(obj2));
        }

        [TestMethod]
        public void addElementTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            Assert.AreEqual(true, objList.addElement(obj1));
        }

        [TestMethod]
        public void multipleAddElementTest()
        {
            DesignElement obj1 = new Ellipses();
            DesignElement obj2 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            Assert.AreEqual(true, objList.addElement(obj2));
        }

        [TestMethod]
        public void singleInsertElementTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            Assert.AreEqual(0, objList.insertElement(0, obj1));
        }

        [TestMethod]
        public void multipleInsertElementTest()
        {
            DesignElement obj1 = new Ellipses();
            DesignElement obj2 = new Ellipses();
            DesignElement obj3 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            objList.addElement(obj3);
            Assert.AreEqual(1, objList.insertElement(1, obj2));
        }

        [TestMethod]
        public void emptyRemoveElementTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            Assert.AreEqual(-1, objList.removeElement(obj1));
        }

        [TestMethod]
        public void notEmptyRemoveElementTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            Assert.AreEqual(0, objList.removeElement(obj1));
        }

        [TestMethod]
        public void multipleRemoveElementTest()
        {
            DesignElement obj1 = new Ellipses();
            DesignElement obj2 = new Ellipses();
            DesignElement obj3 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            objList.addElement(obj2);
            objList.addElement(obj3);
            Assert.AreEqual(1, objList.removeElement(obj2));
        }

        [TestMethod]
        public void emptyRemoveLastElementTest()
        {
            CanvasElementList objList = new CanvasElementList();
            Assert.AreEqual(-1, objList.removeLastElement());
        }

        [TestMethod]
        public void singleRemoveLastElementTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            int size = objList.getListSize();
            Assert.AreEqual(size - 1, objList.removeLastElement());
        }

        [TestMethod]
        public void multipleRemoveLastElementTest()
        {
            DesignElement obj1 = new Ellipses();
            DesignElement obj2 = new Ellipses();
            DesignElement obj3 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            objList.addElement(obj2);
            objList.addElement(obj3);
            int size = objList.getListSize();
            Assert.AreEqual(size - 1, objList.removeLastElement());
        }

        [TestMethod]
        public void clearListTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            Assert.AreEqual(true, objList.clearList());
        }

        //No ShowList test - Paint Event Args - GUI Testing

        [TestMethod]
        public void emptyGetElementTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            Assert.AreEqual(null, objList.getElement(0));
        }

        [TestMethod]
        public void singleGetElementTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            Assert.AreEqual(obj1, objList.getElement(0));
        }

        [TestMethod]
        public void multipleGetElementTest()
        {
            DesignElement obj1 = new Ellipses();
            DesignElement obj2 = new Ellipses();
            DesignElement obj3 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            objList.addElement(obj2);
            objList.addElement(obj3);
            Assert.AreEqual(obj2, objList.getElement(1));
        }

        [TestMethod]
        public void emptyGetSelectedElementTest()
        {
            CanvasElementList objList = new CanvasElementList();
            Assert.AreEqual(null, objList.getSelectedElement());
        }

        [TestMethod]
        public void notEmptyGetSelectedElementTest()
        {
            DesignElement obj1 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            objList.selectElement(75, 50);
            Assert.AreEqual(obj1, objList.getSelectedElement());
        }

        [TestMethod]
        public void notSelectedSelectElementTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            Panel Canvas = new Panel();
            EllipseModMenuView ellipseModMenuView1 = new EllipseModMenuView();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            EMMenuPresenterManager eMMenuPresenterManager = new EMMenuPresenterManager(ellipseModMenuView1,
                Canvas, commandSelector);
            Panel borderPanel = new Panel();
            CanvasElementList objList = new CanvasElementList(eMMenuPresenterManager, borderPanel);
            DesignElement obj1 = new Ellipses();
            objList.addElement(obj1);
            objList.selectElement(0, 0);
            Assert.AreEqual(false, obj1.getIsSelected());
        }

        [TestMethod]
        public void selectedSelectElementTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            Panel Canvas = new Panel();
            EllipseModMenuView ellipseModMenuView1 = new EllipseModMenuView();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            EMMenuPresenterManager eMMenuPresenterManager = new EMMenuPresenterManager(ellipseModMenuView1,
                Canvas, commandSelector);
            Panel borderPanel = new Panel();
            CanvasElementList objList = new CanvasElementList(eMMenuPresenterManager, borderPanel);
            DesignElement obj1 = new Ellipses();
            objList.addElement(obj1);
            objList.selectElement(75, 50);
            Assert.AreEqual(true, obj1.getIsSelected());
        }

        [TestMethod]
        public void notEllipseSelectElementTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            Panel Canvas = new Panel();
            EllipseModMenuView ellipseModMenuView1 = new EllipseModMenuView();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            EMMenuPresenterManager eMMenuPresenterManager = new EMMenuPresenterManager(ellipseModMenuView1,
                Canvas, commandSelector);
            Panel borderPanel = new Panel();
            CanvasElementList objList = new CanvasElementList(eMMenuPresenterManager, borderPanel);
            DesignElement obj1 = new RegularPolygon(isPolygon: false, isTriangle: false, isRectangle: true);
            objList.addElement(obj1);
            objList.selectElement(200, 150);
            Assert.AreEqual(true, obj1.getIsSelected());
        }

        [TestMethod]
        public void clearSelectionTest()
        {
            Label undoLabel = new Label();
            Label redoLabel = new Label();
            Panel Canvas = new Panel();
            EllipseModMenuView ellipseModMenuView1 = new EllipseModMenuView();
            CommandSelector commandSelector = new CommandSelector(undoLabel, redoLabel);
            EMMenuPresenterManager eMMenuPresenterManager = new EMMenuPresenterManager(ellipseModMenuView1,
                Canvas, commandSelector);
            Panel borderPanel = new Panel();
            CanvasElementList objList = new CanvasElementList(eMMenuPresenterManager, borderPanel);
            DesignElement obj1 = new Ellipses();
            DesignElement obj2 = new Ellipses();
            DesignElement obj3 = new Ellipses();
            objList.addElement(obj1);
            objList.addElement(obj2);
            objList.addElement(obj3);
            obj2.setIsSelected(true);
            objList.clearSelection();
            Assert.AreEqual(false, obj2.getIsSelected());
        }

        [TestMethod]
        public void restoreElementTest()
        {
            DesignElement obj1 = new Ellipses();
            DesignElement obj2 = new Ellipses();
            CanvasElementList objList = new CanvasElementList();
            objList.addElement(obj1);
            obj1.setIsSelected(true);
            obj2.setIsSelected(false);
            objList.restoreElement(0, obj2);
            Assert.AreEqual(false, objList.getElement(0).getIsSelected());
        }
    }
}