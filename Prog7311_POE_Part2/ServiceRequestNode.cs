using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog7312_POE_Part2.SharedData;

namespace Prog7312_POE_Part2
{
    public class ServiceRequestNode
    {
        public ServiceRequest Request;
        public ServiceRequestNode Left;
        public ServiceRequestNode Right;

        public ServiceRequestNode(ServiceRequest request)
        {
            Request = request;
        }
    }

    public class ServiceRequestBST
    {
        private ServiceRequestNode root;

        public void Insert(ServiceRequest request)
        {
            root = InsertRec(root, request);
        }

        private ServiceRequestNode InsertRec(ServiceRequestNode node, ServiceRequest request)
        {
            if (node == null) return new ServiceRequestNode(request);
            if (request.ID < node.Request.ID) node.Left = InsertRec(node.Left, request);
            else node.Right = InsertRec(node.Right, request);
            return node;
        }

        public ServiceRequest Search(int id)
        {
            var node = SearchRec(root, id);
            return node?.Request;
        }

        private ServiceRequestNode SearchRec(ServiceRequestNode node, int id)
        {
            if (node == null || node.Request.ID == id) return node;
            return id < node.Request.ID ? SearchRec(node.Left, id) : SearchRec(node.Right, id);
        }

        // Inorder traversal to get all requests sorted by ID
        public List<ServiceRequest> InOrder()
        {
            var list = new List<ServiceRequest>();
            InOrderRec(root, list);
            return list;
        }

        private void InOrderRec(ServiceRequestNode node, List<ServiceRequest> list)
        {
            if (node == null) return;
            InOrderRec(node.Left, list);
            list.Add(node.Request);
            InOrderRec(node.Right, list);
        }

        
    }
}
