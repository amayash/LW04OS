using System.Collections;

namespace LW04
{
    public partial class Form : System.Windows.Forms.Form
    {
        private static Random random = new();
        // заполненные ячейки. 1 - заполнен, 0 - свободен
        private static int[] freeElems;
        // максимальный размер
        private static int maxSizeFS = 128;
        // текущий размер
        private int currCapacity;
        private Bitmap bmp;
        // размеры клеток при отрисовке
        private readonly int xSize;
        private readonly int ySize;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Form()
        {
            InitializeComponent();
            freeElems = new int[maxSizeFS];
            currCapacity = 0;
            bmp = new(pictureBox.Width, pictureBox.Height);
            xSize = pictureBox.Width / 20;
            ySize = xSize;
            treeView.BeginUpdate();
        }

        // кнопки

        /// <summary>
        /// Создание файла
        /// </summary>
        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFile.Text))
            {
                MessageBox.Show("Введите имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (treeView.SelectedNode is TreeNode)
            {
                if (treeView.SelectedNode.Text.Contains(".catalog"))
                {
                    int size = random.Next(1, 10);  //размер файла
                    currCapacity += size;           //текущая вместимость ФС увеличилась
                    if (currCapacity > maxSizeFS)
                    {
                        currCapacity -= size;
                        size = maxSizeFS - currCapacity;
                        currCapacity += size;
                    }
                    if (currCapacity >= maxSizeFS & size == 0)
                    {
                        MessageBox.Show("Переполнение файловой системы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    File file = new File(textBoxFile.Text + ".file", size); //size

                    treeView.SelectedNode.Nodes.Add(file);
                }
            }
            else return;
            treeView.EndUpdate();
            DrawStart();
            pictureBox.Image = bmp;
        }
        /// <summary>
        /// Создание каталога
        /// </summary>
        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCatalog.Text))
            {
                MessageBox.Show("Введите имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (treeView.SelectedNode == null)
                treeView.Nodes.Add(new Catalog(textBoxCatalog.Text + ".catalog"));
            else if (treeView.SelectedNode.Text.Contains(".catalog"))
            {
                treeView.SelectedNode.Nodes.Add(new Catalog(textBoxCatalog.Text + ".catalog"));
            }
            DrawStart();
            treeView.EndUpdate();
        }
        /// <summary>
        /// Выделение выбранного TreeNode
        /// </summary>
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DrawStart();
            if (treeView.SelectedNode is File)
            {
                File file = (File)treeView.SelectedNode;
                Draw(file.iNode);
            }
            else if (treeView.SelectedNode is Catalog)
            {
                CycleCatalog((Catalog)treeView.SelectedNode);
            }
            pictureBox.Image = bmp;
        }
        /// <summary>
        /// Удаление файла/каталога
        /// </summary>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode is File)
            {
                DeleteFile((File)treeView.SelectedNode);
            }
            else if (treeView.SelectedNode is Catalog)
            {
                DeleteCatalog((Catalog)treeView.SelectedNode);
            }

            if (treeView.SelectedNode != null)
                treeView.Nodes.Remove(treeView.SelectedNode);
            DrawStart();
        }
        /// <summary>
        /// Копирование файла/каталога
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode is File)
            {
                CopyFile(treeView.SelectedNode as File, treeView.SelectedNode.Parent);
            }
            else if (treeView.SelectedNode is Catalog)
            {
                TreeNode parent = treeView.SelectedNode.Parent;
                if (currCapacity + CatalogSize(treeView.SelectedNode as Catalog) > maxSizeFS)
                {
                    MessageBox.Show("Переполнение файловой системы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    CopyCatalog((Catalog)treeView.SelectedNode, parent);
                }
            }
        }
        
        // Перемещение TreeNode'ов

        private void treeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }
        private void treeView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        private void treeView_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = treeView.PointToClient(new Point(e.X, e.Y));

            treeView.SelectedNode = treeView.GetNodeAt(targetPoint);
        }
        private void treeView_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = treeView.PointToClient(new Point(e.X, e.Y));

            TreeNode targetNode = treeView.GetNodeAt(targetPoint);

            TreeNode draggedNode;
            if (e.Data.GetData(typeof(Catalog)) is Catalog)
                draggedNode = (Catalog)e.Data.GetData(typeof(Catalog));
            else
                draggedNode = (File)e.Data.GetData(typeof(File));

            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode) && !(targetNode is File))
            {
                if (e.Effect == DragDropEffects.Move)
                {
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                }

                else if (e.Effect == DragDropEffects.Copy)
                {
                    targetNode.Nodes.Add((TreeNode)draggedNode.Clone());
                }

                targetNode.Expand();
            }
        }
        private bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            if (node2.Parent == null) return false;
            if (node2.Parent.Equals(node1)) return true;

            return ContainsNode(node1, node2.Parent);
        }

        // вспомогательные методы (логика)

        /// <summary>
        /// Копирование каталога
        /// </summary>
        /// <param name="catalog">Копируемый каталог</param>
        /// <param name="parent">Родитель каталога</param>
        private void CopyCatalog(Catalog catalog, TreeNode parent)
        {
            if (parent == null)
                treeView.Nodes.Add(new Catalog(catalog.Text + ".copy"));
            else
                parent.Nodes.Add(new Catalog(catalog.Text + ".copy"));

            foreach (TreeNode tn in catalog)
            {
                if (tn is File)
                {
                    if (parent == null)
                        CopyFile(tn as File, treeView.Nodes[treeView.Nodes.Count - 1]);
                    else
                        CopyFile(tn as File, parent.Nodes[parent.Nodes.Count - 1]);
                }
                else if (tn is Catalog)
                {
                    if (parent == null)
                        CopyCatalog(tn as Catalog, treeView.Nodes[treeView.Nodes.Count - 1]);
                    else
                        CopyCatalog(tn as Catalog, parent.Nodes[parent.Nodes.Count - 1]);
                }
            }
        }
        /// <summary>
        /// Копирование файла
        /// </summary>
        /// <param name="curFile">Копируемый файл</param>
        /// <param name="parent">Родитель файла</param>
        private void CopyFile(File curFile, TreeNode parent)
        {
            if (parent.Text.Contains(".catalog"))
            {
                int size = 0;  //размер файла
                iNode temp = curFile.iNode;
                while (temp != null)
                {
                    size += temp.Data.Length;
                    temp = temp.Next;
                }
                currCapacity += size;           //текущая вместимость ФС увеличилась
                if (currCapacity > maxSizeFS)
                {
                    MessageBox.Show("Переполнение файловой системы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                File file = new File(curFile.Text + ".copy", size); //size

                parent.Nodes.Add(file);
            }
            DrawStart();
        }
        /// <summary>
        /// Удаление каталога
        /// </summary>
        /// <param name="catalog">Каталог</param>
        private void DeleteCatalog(Catalog catalog)
        {
            foreach (TreeNode item in catalog)
            {
                if (item is File)
                {
                    DeleteFile((File)item);
                }
                else if (item is Catalog)
                {
                    DeleteCatalog(item as Catalog);
                }
            }
        }
        /// <summary>
        /// Удаление файла
        /// </summary>
        /// <param name="file">Файл</param>
        private void DeleteFile(File file)
        {
            iNode node = file.iNode;
            if (node != null)
            {
                foreach (int index in node.Data)
                {
                    freeElems[index] = 0;
                    currCapacity--;
                }
                while (node.Next != null)
                {
                    node = node.Next;
                    foreach (int index in node.Data)
                    {
                        freeElems[index] = 0;
                        currCapacity--;
                    }
                }
            }

        }
        /// <summary>
        /// Определение размера каталога
        /// </summary>
        /// <param name="catalog">Каталог</param>
        private int CatalogSize(Catalog catalog)
        {
            int size = 0;
            foreach (TreeNode item in catalog)
            {
                if (item is File)
                {
                    iNode temp = (item as File).iNode;
                    while (temp != null)
                    {
                        size += temp.Data.Length;
                        temp = temp.Next;
                    }
                }
                else if (item is Catalog)
                {
                    size += CatalogSize(item as Catalog);
                }
            }
            return size;
        }

        // все, что касается отрисовки

        /// <summary>
        /// Отрисовка всей ФС
        /// </summary>
        private void DrawStart()
        {
            Graphics g = Graphics.FromImage(bmp);

            Brush brGr = new SolidBrush(Color.Gray);
            Brush brBlue = new SolidBrush(Color.Blue);
            Pen pen = new Pen(Color.Black);

            int x = 0;
            int y = 0;

            for (int i = 0; i < freeElems.Length; i++)
            {
                if (freeElems[i] == 0)
                {
                    g.FillRectangle(brGr, x, y, xSize, ySize);
                    g.DrawRectangle(pen, x, y, xSize, ySize);
                    g.DrawString((i + 1).ToString(), new Font("TimesNewRoman", 12), new SolidBrush(Color.Black), new Point(x, y));
                }
                else if (freeElems[i] == 1)
                {
                    g.FillRectangle(brBlue, x, y, xSize, ySize);
                    g.DrawRectangle(pen, x, y, xSize, ySize);
                    g.DrawString((i + 1).ToString(), new Font("TimesNewRoman", 12), new SolidBrush(Color.Black), new Point(x, y));
                }
                x += xSize;
                if (x >= pictureBox.Width)
                {
                    x = 0;
                    y += ySize;
                    if (y >= pictureBox.Height)
                        break;
                }
            }
            pictureBox.Image = bmp;
        }
        /// <summary>
        /// Циклическая отрисовка каталога
        /// </summary>
        /// <param name="catalog">Отрисовываемый каталог</param>
        private void CycleCatalog(Catalog catalog)
        {
            foreach (TreeNode item in catalog)
            {
                if (item is File)
                {
                    File file = item as File;
                    Draw(file.iNode);
                }
                else if (item is Catalog)
                {
                    Catalog temp = item as Catalog;
                    CycleCatalog(temp);
                }
            }
        }
        /// <summary>
        /// Отрисовка выделенных элементов
        /// </summary>
        /// <param name="node">Нода, которую нужно выделить</param>
        private void Draw(iNode node)
        {
            Graphics g = Graphics.FromImage(bmp);

            Brush brRed = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Black);

            int x = 0;
            int y = 0;

            for (int i = 0; i < freeElems.Length; i++)
            {
                if (node != null)
                {
                    if (node.Data.Contains(i))
                    {
                        g.FillRectangle(brRed, x, y, xSize, ySize);
                        g.DrawRectangle(pen, x, y, xSize, ySize);
                        g.DrawString((i + 1).ToString(), new Font("TimesNewRoman", 12), new SolidBrush(Color.Black), new Point(x, y));
                    }
                    if (node.Next != null)
                    {
                        Draw(node.Next);
                    }
                }
                x += xSize;
                if (x >= pictureBox.Width)
                {
                    x = 0;
                    y += ySize;
                    if (y >= pictureBox.Height)
                        break;
                }
            }
        }

        // классы

        /// <summary>
        /// Каталог
        /// </summary>
        public class Catalog : TreeNode
        {
            public Catalog(string name) : base(name)
            {

            }

            public IEnumerator GetEnumerator() => Nodes.GetEnumerator();
        }
        /// <summary>
        /// Файл
        /// </summary>
        public class File : TreeNode
        {
            private int _size;
            private iNode _node;
            private string _name;
            public int Size { get { return _size; } }
            public iNode iNode { get { return _node; } }
            public string Name { get { return _name; } }
            public File(string name, int _size) : base(name)
            {
                _node = new iNode(_size);
                this._size = _size;
            }
        }
        /// <summary>
        /// i-нода
        /// </summary>
        public class iNode
        {
            private int maxSize = 6;    // размер айноды
            private int[] data;         //массив ячеек, которые файл занимает в памяти
            public int[] Data
            {
                get { return data; }
            }
            public iNode Next { get; set; }
            public iNode(int size)
            {
                if (size > maxSize)
                {
                    Next = new iNode(size - maxSize);
                    size = maxSize;
                }
                else Next = null;
                data = new int[size];
                for (int i = 0; i < size; i++)
                {
                    int temp = random.Next(maxSizeFS);  //рандомим ячейку в ФС
                    if (freeElems[temp] == 0)
                        freeElems[temp] = 1;
                    else
                    {
                        temp = Array.IndexOf(freeElems, 0);
                        if (temp == -1)
                        {
                            MessageBox.Show("Индекс вышел за границы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        freeElems[temp] = 1;
                    }
                    data[i] = temp;
                }
            }

        }

        

    }
}