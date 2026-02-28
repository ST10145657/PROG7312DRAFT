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

        public void InitializeSampleData()
        {
            // 🧹 Community Events -> ServiceRequests
            var req1 = new ServiceRequest(201, "Greenfield Park", "Community", "Park Cleanup: Join the community to clean up Greenfield Park. Gloves and bags provided.", "Submitted", 2)
            {
                CreatedAt = DateTime.Now.AddDays(2)
            };
            var req2 = new ServiceRequest(202, "Local Library", "Education", "Coding for Beginners Workshop: Free coding class hosted by the local library.", "Submitted", 1)
            {
                CreatedAt = DateTime.Now.AddDays(4)
            };
            var req3 = new ServiceRequest(203, "Community Center", "Health", "Blood Donation Drive: Donate blood and help save lives. Refreshments provided.", "Submitted", 3)
            {
                CreatedAt = DateTime.Now.AddDays(1)
            };

            // Insert into BST
            SharedServiceRequests.RequestBST.Insert(req1);
            SharedServiceRequests.RequestBST.Insert(req2);
            SharedServiceRequests.RequestBST.Insert(req3);

            // Add to Graph
            SharedServiceRequests.RequestGraph.AddRequest(req1);
            SharedServiceRequests.RequestGraph.AddRequest(req2);
            SharedServiceRequests.RequestGraph.AddRequest(req3);

            // Example dependencies
            SharedServiceRequests.RequestGraph.AddDependency(201, 202); // Park Cleanup depends on Coding Workshop
            SharedServiceRequests.RequestGraph.AddDependency(203, 201); // Blood Drive depends on Park Cleanup

        }
    }
}
